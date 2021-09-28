
namespace lab05_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.btnXem = new System.Windows.Forms.Button();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.datetimeBegin = new System.Windows.Forms.DateTimePicker();
            this.rdoTungNgay = new System.Windows.Forms.RadioButton();
            this.datetimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlRb = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datetimeThang = new System.Windows.Forms.DateTimePicker();
            this.datetimeNgay = new System.Windows.Forms.DateTimePicker();
            this.pnlRb.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thoi Gian Giao Hang";
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Location = new System.Drawing.Point(6, 5);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(96, 17);
            this.rdoNgay.TabIndex = 1;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Tag = "1";
            this.rdoNgay.Text = "XemTheoNgay";
            this.rdoNgay.UseVisualStyleBackColor = true;
            this.rdoNgay.Click += new System.EventHandler(this.rdoNgay_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(458, 158);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "In/Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(3, 55);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(108, 17);
            this.rdoThang.TabIndex = 4;
            this.rdoThang.TabStop = true;
            this.rdoThang.Tag = "2";
            this.rdoThang.Text = "Xem Theo Thang";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.Click += new System.EventHandler(this.rdoNgay_Click);
            // 
            // datetimeBegin
            // 
            this.datetimeBegin.CustomFormat = "yyyy-MM-dd";
            this.datetimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeBegin.Location = new System.Drawing.Point(5, 16);
            this.datetimeBegin.Name = "datetimeBegin";
            this.datetimeBegin.Size = new System.Drawing.Size(103, 20);
            this.datetimeBegin.TabIndex = 7;
            // 
            // rdoTungNgay
            // 
            this.rdoTungNgay.AutoSize = true;
            this.rdoTungNgay.Location = new System.Drawing.Point(6, 107);
            this.rdoTungNgay.Name = "rdoTungNgay";
            this.rdoTungNgay.Size = new System.Drawing.Size(102, 17);
            this.rdoTungNgay.TabIndex = 6;
            this.rdoTungNgay.TabStop = true;
            this.rdoTungNgay.Tag = "3";
            this.rdoTungNgay.Text = "Xem Tung Ngay";
            this.rdoTungNgay.UseVisualStyleBackColor = true;
            this.rdoTungNgay.Click += new System.EventHandler(this.rdoNgay_Click);
            // 
            // datetimeEnd
            // 
            this.datetimeEnd.CustomFormat = "yyyy-MM-dd";
            this.datetimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeEnd.Location = new System.Drawing.Point(134, 16);
            this.datetimeEnd.Name = "datetimeEnd";
            this.datetimeEnd.Size = new System.Drawing.Size(103, 20);
            this.datetimeEnd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "~";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 187);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(703, 251);
            this.reportViewer1.TabIndex = 10;
            // 
            // pnlRb
            // 
            this.pnlRb.Controls.Add(this.rdoTungNgay);
            this.pnlRb.Controls.Add(this.rdoNgay);
            this.pnlRb.Controls.Add(this.rdoThang);
            this.pnlRb.Location = new System.Drawing.Point(224, 12);
            this.pnlRb.Name = "pnlRb";
            this.pnlRb.Size = new System.Drawing.Size(119, 140);
            this.pnlRb.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datetimeBegin);
            this.panel2.Controls.Add(this.datetimeEnd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(349, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 49);
            this.panel2.TabIndex = 13;
            // 
            // datetimeThang
            // 
            this.datetimeThang.CustomFormat = "yyyy-MM";
            this.datetimeThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeThang.Location = new System.Drawing.Point(350, 67);
            this.datetimeThang.Name = "datetimeThang";
            this.datetimeThang.Size = new System.Drawing.Size(103, 20);
            this.datetimeThang.TabIndex = 5;
            // 
            // datetimeNgay
            // 
            this.datetimeNgay.CustomFormat = "yyyy-MM-dd";
            this.datetimeNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNgay.Location = new System.Drawing.Point(349, 17);
            this.datetimeNgay.Name = "datetimeNgay";
            this.datetimeNgay.Size = new System.Drawing.Size(103, 20);
            this.datetimeNgay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.datetimeThang);
            this.Controls.Add(this.datetimeNgay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlRb);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRb.ResumeLayout(false);
            this.pnlRb.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.DateTimePicker datetimeBegin;
        private System.Windows.Forms.RadioButton rdoTungNgay;
        private System.Windows.Forms.DateTimePicker datetimeEnd;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel pnlRb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker datetimeThang;
        private System.Windows.Forms.DateTimePicker datetimeNgay;
    }
}

