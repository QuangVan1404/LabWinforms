using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frm1 : Form
    {
        private int stt = 1;
        public frm1()
        {
            InitializeComponent();
        }
        
        private void clear()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
        }
        private bool Validate(object sender)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "")
            {
                errorProvider1.SetError(txt, "Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            errorProvider1.SetError(txt, "");
            return true;
        }
        private void txt1_Validating(object sender, CancelEventArgs e)
        {
            Validate(sender);
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tinhTongTien()
        {
            float tongTien = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                tongTien += float.Parse(listView1.Items[i].SubItems[4].Text);
            }
            txt5.Text = tongTien.ToString();
        }

        private int timSoTaiKhoan(string soTaiKhoan)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == soTaiKhoan)
                    return i;
            }
            return -1;
        }

        private void capNhatThongTin(int sttSoTaiKhoan)
        {
            listView1.Items[sttSoTaiKhoan].SubItems[1].Text = txt1.Text;
            listView1.Items[sttSoTaiKhoan].SubItems[2].Text = txt2.Text;
            listView1.Items[sttSoTaiKhoan].SubItems[3].Text = txt3.Text;
            listView1.Items[sttSoTaiKhoan].SubItems[4].Text = txt4.Text;
        }

        private void binding(int selectedIndex)
        {
            if (selectedIndex == -1) return;
            txt1.Text = listView1.Items[selectedIndex].SubItems[1].Text;
            txt2.Text = listView1.Items[selectedIndex].SubItems[2].Text;
            txt3.Text = listView1.Items[selectedIndex].SubItems[3].Text;
            txt4.Text = listView1.Items[selectedIndex].SubItems[4].Text;
        }
        private bool kiemTraHopLe()
        {
            if (errorProvider1.GetError(txt1) != "" || errorProvider1.GetError(txt2) != "" || errorProvider1.GetError(txt3) != "" || errorProvider1.GetError(txt4) != "") 
                return false;
            return true;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (!kiemTraHopLe()) return;
            ListViewItem item = new ListViewItem(new string[] { (stt).ToString(), txt1.Text, txt2.Text, txt3.Text, txt4.Text });
            if (timSoTaiKhoan(txt1.Text) == -1)
            { 
                listView1.Items.Add(item);
                stt++;
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thêm thành công", MessageBoxButtons.OK);
            } else
            {
                capNhatThongTin(timSoTaiKhoan(txt1.Text));
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Cập nhật thành công", MessageBoxButtons.OK);
            }
            tinhTongTien();
            clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var selected = listView1.SelectedItems.Cast<Object>().ToArray();
            if (selected.Length <= 0) return;
            DialogResult dr = MessageBox.Show("Xoá thông tin", "Bạn có muốn xoá thông tin này không?", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes) {
                foreach (ListViewItem item in selected)
                    listView1.Items.Remove(item);
                stt--;
            }
            MessageBox.Show("Xoá dữ liệu thành công!", "Xoá dữ liệu thành công!", MessageBoxButtons.OK);
            tinhTongTien();
            clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null) return;
            int p = listView1.FocusedItem.Index;
            binding(p);
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
