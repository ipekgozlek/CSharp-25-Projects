namespace Doviz_Ofisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.BtnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.Location = new System.Drawing.Point(114, 24);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(14, 16);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Alış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Satış:";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.Location = new System.Drawing.Point(122, 52);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(14, 16);
            this.LblDolarSatis.TabIndex = 5;
            this.LblDolarSatis.Text = "0";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.Location = new System.Drawing.Point(111, 81);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(14, 16);
            this.LblEuroAlis.TabIndex = 6;
            this.LblEuroAlis.Text = "0";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.Location = new System.Drawing.Point(120, 111);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(14, 16);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Location = new System.Drawing.Point(196, 12);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(38, 28);
            this.BtnDolarAl.TabIndex = 8;
            this.BtnDolarAl.Text = "...";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(33, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(68, 25);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(161, 22);
            this.TxtKur.TabIndex = 10;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnSatisYap2);
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Location = new System.Drawing.Point(196, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 191);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(18, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(68, 53);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(161, 22);
            this.TxtMiktar.TabIndex = 12;
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(196, 44);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(38, 28);
            this.BtnDolarSat.TabIndex = 12;
            this.BtnDolarSat.Text = "...";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Location = new System.Drawing.Point(196, 75);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(38, 28);
            this.BtnEuroAl.TabIndex = 13;
            this.BtnEuroAl.Text = "...";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Location = new System.Drawing.Point(196, 105);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(38, 28);
            this.BtnEuroSat.TabIndex = 14;
            this.BtnEuroSat.Text = "...";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(19, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tutar:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(68, 83);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(161, 22);
            this.TxtTutar.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(19, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(68, 111);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(161, 22);
            this.TxtKalan.TabIndex = 16;
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Location = new System.Drawing.Point(73, 139);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(75, 23);
            this.BtnSatisYap.TabIndex = 17;
            this.BtnSatisYap.Text = "İşlem 1";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // BtnSatisYap2
            // 
            this.BtnSatisYap2.Location = new System.Drawing.Point(154, 139);
            this.BtnSatisYap2.Name = "BtnSatisYap2";
            this.BtnSatisYap2.Size = new System.Drawing.Size(75, 23);
            this.BtnSatisYap2.TabIndex = 18;
            this.BtnSatisYap2.Text = "İşlem 2";
            this.BtnSatisYap2.UseVisualStyleBackColor = true;
            this.BtnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doviz_Ofisi.Properties.Resources.images__1_1;
            this.ClientSize = new System.Drawing.Size(546, 408);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Button BtnSatisYap2;
    }
}

