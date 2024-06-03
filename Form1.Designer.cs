namespace Csharp_tínhđiểmTB
{
    partial class Form1
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
            this.lblten = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.txttb = new System.Windows.Forms.TextBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.btntinhtrungbinh = new System.Windows.Forms.Button();
            this.lbltoan = new System.Windows.Forms.Label();
            this.lblvan = new System.Windows.Forms.Label();
            this.lbltrungbinh = new System.Windows.Forms.Label();
            this.lblxeploai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Location = new System.Drawing.Point(83, 101);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(36, 20);
            this.lblten.TabIndex = 0;
            this.lblten.Text = "Tên";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(193, 101);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 1;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(682, 402);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(92, 26);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(193, 139);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 3;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(193, 176);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 4;
            // 
            // txttb
            // 
            this.txttb.Location = new System.Drawing.Point(193, 260);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(100, 20);
            this.txttb.TabIndex = 5;
            // 
            // txtxeploai
            // 
            this.txtxeploai.Location = new System.Drawing.Point(193, 297);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(100, 20);
            this.txtxeploai.TabIndex = 6;
            // 
            // btntinhtrungbinh
            // 
            this.btntinhtrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtrungbinh.Location = new System.Drawing.Point(338, 357);
            this.btntinhtrungbinh.Name = "btntinhtrungbinh";
            this.btntinhtrungbinh.Size = new System.Drawing.Size(172, 34);
            this.btntinhtrungbinh.TabIndex = 7;
            this.btntinhtrungbinh.Text = "Tính Trung Bình ";
            this.btntinhtrungbinh.UseVisualStyleBackColor = true;
            this.btntinhtrungbinh.Click += new System.EventHandler(this.btntinhtrungbinh_Click);
            // 
            // lbltoan
            // 
            this.lbltoan.AutoSize = true;
            this.lbltoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoan.Location = new System.Drawing.Point(83, 139);
            this.lbltoan.Name = "lbltoan";
            this.lbltoan.Size = new System.Drawing.Size(45, 20);
            this.lbltoan.TabIndex = 8;
            this.lbltoan.Text = "Toán";
            // 
            // lblvan
            // 
            this.lblvan.AutoSize = true;
            this.lblvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvan.Location = new System.Drawing.Point(83, 176);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(38, 20);
            this.lblvan.TabIndex = 9;
            this.lblvan.Text = "Văn";
            // 
            // lbltrungbinh
            // 
            this.lbltrungbinh.AutoSize = true;
            this.lbltrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrungbinh.Location = new System.Drawing.Point(83, 260);
            this.lbltrungbinh.Name = "lbltrungbinh";
            this.lbltrungbinh.Size = new System.Drawing.Size(86, 20);
            this.lbltrungbinh.TabIndex = 10;
            this.lbltrungbinh.Text = "Trung Bình";
            // 
            // lblxeploai
            // 
            this.lblxeploai.AutoSize = true;
            this.lblxeploai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxeploai.Location = new System.Drawing.Point(83, 297);
            this.lblxeploai.Name = "lblxeploai";
            this.lblxeploai.Size = new System.Drawing.Size(72, 20);
            this.lblxeploai.TabIndex = 11;
            this.lblxeploai.Text = "Xếp Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 55);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tính Điểm ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblxeploai);
            this.Controls.Add(this.lbltrungbinh);
            this.Controls.Add(this.lblvan);
            this.Controls.Add(this.lbltoan);
            this.Controls.Add(this.btntinhtrungbinh);
            this.Controls.Add(this.txtxeploai);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.TextBox txttb;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Button btntinhtrungbinh;
        private System.Windows.Forms.Label lbltoan;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.Label lbltrungbinh;
        private System.Windows.Forms.Label lblxeploai;
        private System.Windows.Forms.Label label6;
    }
}

