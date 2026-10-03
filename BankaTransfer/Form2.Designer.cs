namespace BankaTransfer
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblHesapNo = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.MSkHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik:";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(228, 74);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(64, 24);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "NULL";
            // 
            // LblHesapNo
            // 
            this.LblHesapNo.AutoSize = true;
            this.LblHesapNo.Location = new System.Drawing.Point(231, 119);
            this.LblHesapNo.Name = "LblHesapNo";
            this.LblHesapNo.Size = new System.Drawing.Size(64, 24);
            this.LblHesapNo.TabIndex = 5;
            this.LblHesapNo.Text = "NULL";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(234, 166);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(64, 24);
            this.LblTelefon.TabIndex = 6;
            this.LblTelefon.Text = "NULL";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(231, 209);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(64, 24);
            this.LblTc.TabIndex = 7;
            this.LblTc.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LnkKayitOl);
            this.groupBox1.Controls.Add(this.BtnGonder);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.MSkHesapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(3, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 211);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // LnkKayitOl
            // 
            this.LnkKayitOl.AutoSize = true;
            this.LnkKayitOl.LinkColor = System.Drawing.Color.Red;
            this.LnkKayitOl.Location = new System.Drawing.Point(238, 89);
            this.LnkKayitOl.Name = "LnkKayitOl";
            this.LnkKayitOl.Size = new System.Drawing.Size(83, 24);
            this.LnkKayitOl.TabIndex = 9;
            this.LnkKayitOl.TabStop = true;
            this.LnkKayitOl.Text = "Kayıt Ol";
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(119, 134);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(99, 36);
            this.BtnGonder.TabIndex = 6;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tutar:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(122, 89);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(100, 30);
            this.TxtTutar.TabIndex = 4;
            // 
            // MSkHesapNo
            // 
            this.MSkHesapNo.Location = new System.Drawing.Point(122, 38);
            this.MSkHesapNo.Mask = "000000";
            this.MSkHesapNo.Name = "MSkHesapNo";
            this.MSkHesapNo.Size = new System.Drawing.Size(100, 30);
            this.MSkHesapNo.TabIndex = 3;
            this.MSkHesapNo.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hesap No:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(577, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblHesapNo);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblHesapNo;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MSkHesapNo;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.LinkLabel LnkKayitOl;
    }
}