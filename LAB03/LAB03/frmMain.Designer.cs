
namespace LAB03
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.CheckBox();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.dgv);
            this.gb.Controls.Add(this.lbl2);
            this.gb.Controls.Add(this.dateTimePicker2);
            this.gb.Controls.Add(this.dateTimePicker1);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.cb);
            this.gb.Location = new System.Drawing.Point(27, 36);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(744, 390);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.soHD,
            this.ngayDatHang,
            this.ngayGiaoHang,
            this.thanhTien});
            this.dgv.Location = new System.Drawing.Point(6, 121);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(716, 253);
            this.dgv.TabIndex = 5;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // soHD
            // 
            this.soHD.HeaderText = "SỐ HĐ";
            this.soHD.Name = "soHD";
            // 
            // ngayDatHang
            // 
            this.ngayDatHang.HeaderText = "NGÀY ĐẶT HÀNG";
            this.ngayDatHang.Name = "ngayDatHang";
            // 
            // ngayGiaoHang
            // 
            this.ngayGiaoHang.HeaderText = "NGÀY GIAO HÀNG";
            this.ngayGiaoHang.Name = "ngayGiaoHang";
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "THÀNH TIỀN";
            this.thanhTien.Name = "thanhTien";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(328, 78);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(14, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(348, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỜI GIAN GIAO HÀNG";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(94, 38);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(173, 17);
            this.cb.TabIndex = 0;
            this.cb.Text = "XEM TẤT CẢ TRONG THÁNG";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb);
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGiaoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
    }
}

