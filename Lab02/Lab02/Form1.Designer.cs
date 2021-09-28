
namespace Lab02
{
    partial class frm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvStt = new System.Windows.Forms.ColumnHeader();
            this.lvMaTaiKhoan = new System.Windows.Forms.ColumnHeader();
            this.lvTenKhachHang = new System.Windows.Forms.ColumnHeader();
            this.lvDiaChi = new System.Windows.Forms.ColumnHeader();
            this.lvSoTien = new System.Windows.Forms.ColumnHeader();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl1.Location = new System.Drawing.Point(179, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(479, 40);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(76, 88);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Số tài khoản";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(76, 131);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(98, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Tên khách hàng";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(76, 175);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(117, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Địa chỉ khách hàng";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(76, 224);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(141, 17);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Số tiền trong tài khoản";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(223, 82);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(466, 23);
            this.txt1.TabIndex = 5;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt1.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_Validating);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(223, 130);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(466, 23);
            this.txt2.TabIndex = 6;
            this.txt2.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_Validating);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(223, 174);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(466, 23);
            this.txt3.TabIndex = 7;
            this.txt3.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_Validating);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(223, 218);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(466, 23);
            this.txt4.TabIndex = 8;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt4.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_Validating);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(347, 267);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 23);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "Thêm/Cập nhật";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(463, 267);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(110, 23);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "Xoá";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(579, 267);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(110, 23);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "Thoát";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvStt,
            this.lvMaTaiKhoan,
            this.lvTenKhachHang,
            this.lvDiaChi,
            this.lvSoTien});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(87, 310);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 195);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvStt
            // 
            this.lvStt.Text = "STT";
            this.lvStt.Width = 40;
            // 
            // lvMaTaiKhoan
            // 
            this.lvMaTaiKhoan.Text = "Mã tài khoản";
            this.lvMaTaiKhoan.Width = 100;
            // 
            // lvTenKhachHang
            // 
            this.lvTenKhachHang.Text = "Tên khách hàng";
            this.lvTenKhachHang.Width = 150;
            // 
            // lvDiaChi
            // 
            this.lvDiaChi.Text = "Địa chỉ";
            this.lvDiaChi.Width = 200;
            // 
            // lvSoTien
            // 
            this.lvSoTien.Text = "Số tiền";
            this.lvSoTien.Width = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(579, 511);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(110, 23);
            this.txt5.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(505, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tổng tiền";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.listView1);
            this.Name = "frm1";
            this.Text = "Quản Lý Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader lvStt;
        private System.Windows.Forms.ColumnHeader lvMaTaiKhoan;
        private System.Windows.Forms.ColumnHeader lvTenKhachHang;
        private System.Windows.Forms.ColumnHeader lvDiaChi;
        public System.Windows.Forms.ColumnHeader lvSoTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt5;
    }
}

