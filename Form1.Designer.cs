namespace csharp_fromater
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
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radred = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkNghiên = new System.Windows.Forms.CheckBox();
            this.chkgachchan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLapTrinh = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(249, 63);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(206, 20);
            this.txtnhapten.TabIndex = 0;
            this.txtnhapten.Text = "an2008";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên ";
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(26, 30);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(48, 19);
            this.radred.TabIndex = 4;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = false;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Location = new System.Drawing.Point(84, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR";
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.radgreen.Location = new System.Drawing.Point(26, 64);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(59, 19);
            this.radgreen.TabIndex = 5;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radblue.Location = new System.Drawing.Point(29, 98);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(50, 19);
            this.radblue.TabIndex = 6;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblack.Location = new System.Drawing.Point(29, 134);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(55, 19);
            this.radblack.TabIndex = 7;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.chkgachchan);
            this.groupBox2.Controls.Add(this.chkNghiên);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Location = new System.Drawing.Point(392, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 208);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FONT";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Salmon;
            this.chkBold.Location = new System.Drawing.Point(48, 49);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(81, 19);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkNghiên
            // 
            this.chkNghiên.AutoSize = true;
            this.chkNghiên.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghiên.ForeColor = System.Drawing.Color.Salmon;
            this.chkNghiên.Location = new System.Drawing.Point(60, 99);
            this.chkNghiên.Name = "chkNghiên";
            this.chkNghiên.Size = new System.Drawing.Size(94, 19);
            this.chkNghiên.TabIndex = 1;
            this.chkNghiên.Text = "Nghiên Italic";
            this.chkNghiên.UseVisualStyleBackColor = true;
            this.chkNghiên.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkgachchan
            // 
            this.chkgachchan.AutoSize = true;
            this.chkgachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgachchan.ForeColor = System.Drawing.Color.Salmon;
            this.chkgachchan.Location = new System.Drawing.Point(48, 146);
            this.chkgachchan.Name = "chkgachchan";
            this.chkgachchan.Size = new System.Drawing.Size(85, 19);
            this.chkgachchan.TabIndex = 2;
            this.chkgachchan.Text = "Gạch chân";
            this.chkgachchan.UseVisualStyleBackColor = true;
            this.chkgachchan.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lập trình Bởi ";
            // 
            // lbLapTrinh
            // 
            this.lbLapTrinh.AutoSize = true;
            this.lbLapTrinh.Location = new System.Drawing.Point(228, 391);
            this.lbLapTrinh.Name = "lbLapTrinh";
            this.lbLapTrinh.Size = new System.Drawing.Size(76, 13);
            this.lbLapTrinh.TabIndex = 8;
            this.lbLapTrinh.Text = "an2008           ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLapTrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnhapten);
            this.Name = "Form1";
            this.Text = "định dạng(Fromater)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkgachchan;
        private System.Windows.Forms.CheckBox chkNghiên;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLapTrinh;
    }
}

