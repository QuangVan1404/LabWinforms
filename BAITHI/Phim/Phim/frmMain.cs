
using Phim.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phim
{   
    public partial class frmMain : Form
    {
        List<PHIM> phims;
        List<LOAIPHIM> loaiPhims;
        PHIMMODEL dbContext;
        public frmMain()
        {
            dbContext = new PHIMMODEL();
            InitializeComponent();
            phims = dbContext.PHIMs.ToList();
            loaiPhims = dbContext.LOAIPHIMs.ToList();
            FillDataDGV(phims);
            FillDataCBB(loaiPhims);
        }
        private void FillDataCBB(List<LOAIPHIM> list)
        {
            this.cbTheLoai.DataSource = list;
            this.cbTheLoai.DisplayMember = "TenLP";
            this.cbTheLoai.ValueMember = "MaLP";
        }
        private void FillDataDGV(List<PHIM> list)
        {
            if (list == null) return;
            dgv.Rows.Clear();
            foreach (var item in list)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = item.MaPH;
                dgv.Rows[index].Cells[1].Value = item.TenPH;
                dgv.Rows[index].Cells[2].Value = item.NgayCC;
                dgv.Rows[index].Cells[3].Value = item.LOAIPHIM.TenLP;
            }
        }
        private void ResetForm()
        {
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            cbTheLoai.Text = "";
            dtpNgayCC.Text = "";
        }
        public bool KiemTraDuLieu()
        {
            if (txtMaPhim.Text == "" || txtTenPhim.Text == "" || cbTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else if (txtMaPhim.TextLength != 5)
            {
                MessageBox.Show("Mã phim chưa đúng, phải 5 ký tự!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private int Check(string id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[0].Value != null)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() == id)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                txtMaPhim.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenPhim.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                dtpNgayCC.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                cbTheLoai.SelectedIndex = cbTheLoai.FindString(dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var p = dbContext.PHIMs.FirstOrDefault(ph => ph.MaPH == txtMaPhim.Text);
            if (p != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có muốn xóa không {p.TenPH}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dbContext.PHIMs.Remove(p);
                    dbContext.SaveChanges();
                    ResetForm();
                    phims = dbContext.PHIMs.ToList();
                    FillDataDGV(phims);
                    MessageBox.Show("Xóa phim thành công!", "Thông báo", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("Phim cần xóa không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {

                if (Check(txtTenPhim.Text) == -1)
                {
                    var p = new PHIM();
                    p.MaPH = txtMaPhim.Text;
                    p.TenPH = txtTenPhim.Text;
                    p.NgayCC = DateTime.Parse(dtpNgayCC.Text);
                    p.MaLP =cbTheLoai.SelectedValue.ToString();
                    dbContext.PHIMs.AddOrUpdate(p);
                    dbContext.SaveChanges();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Phim đã tồn tại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            phims = dbContext.PHIMs.ToList();
            FillDataDGV(phims);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var updatePhim = dbContext.PHIMs.FirstOrDefault(
                   p => p.MaPH == txtMaPhim.Text);
            if (updatePhim != null)
            {
                updatePhim.TenPH = txtTenPhim.Text;
                updatePhim.NgayCC = DateTime.Parse(dtpNgayCC.Text);
                updatePhim.MaLP = cbTheLoai.SelectedValue.ToString();
                dbContext.PHIMs.AddOrUpdate(updatePhim);
                dbContext.SaveChanges();
                FillDataDGV(phims);
                ResetForm();
                MessageBox.Show("Chỉnh sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy phim cần sửa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void thốngKêTheoLoạiPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rp = new report();
            rp.Show();
        }
        private void dtpTimKiem_ValueChanged(object sender, EventArgs e)
        {
            var listKq = new List<PHIM>();
            foreach (var kq in phims)
            {
                if (kq.NgayCC.ToString("MM-dd-yyyy") == dtpTimKiem.Text)
                { listKq.Add(kq); }
            }
            if (listKq.Count == 0) return;
            FillDataDGV(listKq);
        }
    }
}
