using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab05_02.model1;
using Microsoft.Reporting.WinForms;

namespace lab05_02
{
    public partial class frmMain : Form
    {
        private List<ketQua> dsKq; 
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
        }
        private void rdoNgay_Click(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            datetimeNgay.Enabled = false;
            datetimeThang.Enabled = false;
            panel2.Enabled = false;
            foreach (var item in pnlRb.Controls)
            {
                if (!rb.Checked) continue;
                switch (rb.Tag.ToString())
                {
                    case "1":
                        datetimeNgay.Enabled = true;
                        break;
                    case "2":
                        datetimeThang.Enabled = true;
                        break;
                    default:
                        panel2.Enabled = true;
                        break;
                }
            }
        }
        private List<ketQua> danhSachKetQua()
        {
            using (var dbcontext = new HoaDonModel())
            {
                return (from hd in dbcontext.HoaDons
                        join dh in dbcontext.DonHangs on hd.SoHD equals dh.SoHD
                        select new ketQua()
                        {
                            SoHD = hd.SoHD,
                            tongTien = dh.SoLuong * dh.DonGia,
                            GiaoHang = hd.GiaoHang,
                            DatHang = hd.DatHang
                        }).ToList();
            }
        }
        private List<ketQua> timKiem(bool thang, string ngay)
        {
            var listKq = new List<ketQua>();
            if (thang)
            {
                foreach (var kq in dsKq)
                    if(kq.GiaoHang.ToString("yyyy-MM") == ngay)
                        listKq.Add(kq);
            }
            else
            {
                foreach (var kq in dsKq)
                    if (kq.GiaoHang.ToString("yyyy-MM-dd") == ngay)
                        listKq.Add(kq);
            }
            
            return listKq;
        }
        private List<ketQua> tiemKiemTheoKhoang(long ticksBegin, long ticksEnd)
        {
            var listKq = new List<ketQua>();
            foreach (var kq in dsKq)
                if (kq.GiaoHang.Ticks < ticksEnd && ticksBegin < kq.DatHang.Ticks)
                    listKq.Add(kq);

            return listKq;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            dsKq = danhSachKetQua();
            string theDate;
            foreach (Control control in pnlRb.Controls)
             {
                var rb = (RadioButton)control;
                 if (!rb.Checked) continue;
                 switch (rb.Tag.ToString())
                 {
                     case "1":
                        theDate = datetimeNgay.Value.ToString("yyyy-MM-dd");
                        dsKq = timKiem(false,theDate);
                        break;
                     case "2":
                        theDate = datetimeThang.Value.ToString("yyyy-MM");
                        dsKq = timKiem(true,theDate);
                        break; 
                    default:
                       var ticksBegin = datetimeBegin.Value.Ticks;
                       var tickseEnd = datetimeEnd.Value.Ticks;
                        dsKq = tiemKiemTheoKhoang(ticksBegin, tickseEnd);
                        break;
                 }
             }

            reportViewer1.Visible = true;
            reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = ("./reportHoaDon/ReportHoaDon.rdlc");
            var ReportDataSource = new ReportDataSource("ketQua", dsKq);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ReportDataSource);
        }
    }
}
