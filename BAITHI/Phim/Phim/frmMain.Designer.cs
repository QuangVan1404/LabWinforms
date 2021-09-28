
namespace Phim
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.dtpNgayCC = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.maPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoLoạiPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpTimKiem = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.dtpNgayCC);
            this.groupBox1.Controls.Add(this.txtTenPhim);
            this.groupBox1.Controls.Add(this.txtMaPhim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phim";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(124, 230);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cbTheLoai.TabIndex = 12;
            // 
            // dtpNgayCC
            // 
            this.dtpNgayCC.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayCC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCC.Location = new System.Drawing.Point(122, 173);
            this.dtpNgayCC.Name = "dtpNgayCC";
            this.dtpNgayCC.Size = new System.Drawing.Size(124, 20);
            this.dtpNgayCC.TabIndex = 11;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(121, 112);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(124, 20);
            this.txtTenPhim.TabIndex = 9;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(121, 52);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(124, 20);
            this.txtMaPhim.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Công Chiéu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thể Loại";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhim,
            this.tenPhim,
            this.ngayCC,
            this.theLoai});
            this.dgv.Location = new System.Drawing.Point(305, 116);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(483, 294);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // maPhim
            // 
            this.maPhim.HeaderText = "Mã Phim";
            this.maPhim.Name = "maPhim";
            this.maPhim.ReadOnly = true;
            // 
            // tenPhim
            // 
            this.tenPhim.HeaderText = "Tên Phim";
            this.tenPhim.Name = "tenPhim";
            this.tenPhim.ReadOnly = true;
            this.tenPhim.Width = 150;
            // 
            // ngayCC
            // 
            this.ngayCC.HeaderText = "Ngày Công Chiếu";
            this.ngayCC.Name = "ngayCC";
            this.ngayCC.ReadOnly = true;
            this.ngayCC.Width = 130;
            // 
            // theLoai
            // 
            this.theLoai.HeaderText = "Thể Loại";
            this.theLoai.Name = "theLoai";
            this.theLoai.ReadOnly = true;
            this.theLoai.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lí Thông Tin Phim";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 416);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(221, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(121, 416);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêTheoLoạiPhimToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.thốngKêToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // thốngKêTheoLoạiPhimToolStripMenuItem
            // 
            this.thốngKêTheoLoạiPhimToolStripMenuItem.Name = "thốngKêTheoLoạiPhimToolStripMenuItem";
            this.thốngKêTheoLoạiPhimToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.thốngKêTheoLoạiPhimToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.thốngKêTheoLoạiPhimToolStripMenuItem.Text = "THỐNG KÊ LOẠI PHIM";
            this.thốngKêTheoLoạiPhimToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTheoLoạiPhimToolStripMenuItem_Click);
            // 
            // dtpTimKiem
            // 
            this.dtpTimKiem.CustomFormat = "MM-dd-yyyy";
            this.dtpTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiem.Location = new System.Drawing.Point(625, 77);
            this.dtpTimKiem.Name = "dtpTimKiem";
            this.dtpTimKiem.Size = new System.Drawing.Size(123, 20);
            this.dtpTimKiem.TabIndex = 6;
            this.dtpTimKiem.ValueChanged += new System.EventHandler(this.dtpTimKiem_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản Lý Thông Tin Phim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayCC;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoLoạiPhimToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpTimKiem;
    }
}

