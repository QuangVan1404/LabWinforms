using Phim.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Phim
{
    public partial class report : Form
    {
        private List<PHIMDTO> DS;
        public report()
        {
            InitializeComponent();
            DS = danhSach();
        }

        private void report_Load(object sender, EventArgs e)
        {
            rpPhim.Visible = true;
            this.rpPhim.LocalReport.ReportPath = ("./REPORT/RP.rdlc");
            var ReportDataSource = new ReportDataSource("DataSet1", DS);
            this.rpPhim.LocalReport.DataSources.Clear();
            this.rpPhim.LocalReport.DataSources.Add(ReportDataSource);
            this.rpPhim.RefreshReport();
        }
        private List<PHIMDTO> danhSach()
        {
            using (var dbcontext = new PHIMMODEL())
            {
                return (from hd in dbcontext.PHIMs
                        join dh in dbcontext.LOAIPHIMs on hd.MaLP equals dh.MaLP
                        select new PHIMDTO()
                        {
                            TenLP = dh.TenLP,
                            TenPH = hd.TenPH,
                            NgayCC = hd.NgayCC,
                            MaPH = hd.MaPH
                        }).OrderByDescending(d => d.NgayCC).ToList();
            }
        }
    }  
}
