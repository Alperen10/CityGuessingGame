namespace SehirTahminOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpOyunAlanı = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.btnHarfGir = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGirilenHarfler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOyunAlanı
            // 
            this.grpOyunAlanı.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpOyunAlanı.Location = new System.Drawing.Point(151, 82);
            this.grpOyunAlanı.Name = "grpOyunAlanı";
            this.grpOyunAlanı.Size = new System.Drawing.Size(492, 146);
            this.grpOyunAlanı.TabIndex = 0;
            this.grpOyunAlanı.TabStop = false;
            this.grpOyunAlanı.Text = "Soru Alanı";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.lblKalanHak);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblGirilenHarfler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTahminEt);
            this.groupBox1.Controls.Add(this.txtKelime);
            this.groupBox1.Controls.Add(this.btnHarfGir);
            this.groupBox1.Controls.Add(this.txtHarf);
            this.groupBox1.Location = new System.Drawing.Point(151, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevap Alanı";
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.Location = new System.Drawing.Point(151, 23);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(492, 53);
            this.btnYeniOyun.TabIndex = 2;
            this.btnYeniOyun.Text = "Yeni Oyun Başlat";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(7, 32);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(113, 22);
            this.txtHarf.TabIndex = 0;
            // 
            // btnHarfGir
            // 
            this.btnHarfGir.Location = new System.Drawing.Point(140, 32);
            this.btnHarfGir.Name = "btnHarfGir";
            this.btnHarfGir.Size = new System.Drawing.Size(81, 23);
            this.btnHarfGir.TabIndex = 1;
            this.btnHarfGir.Text = "Harf Gir";
            this.btnHarfGir.UseVisualStyleBackColor = true;
            this.btnHarfGir.Click += new System.EventHandler(this.btnHarfGir_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(254, 33);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(125, 22);
            this.txtKelime.TabIndex = 2;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(385, 32);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(90, 23);
            this.btnTahminEt.TabIndex = 3;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler:";
            // 
            // lblGirilenHarfler
            // 
            this.lblGirilenHarfler.AutoSize = true;
            this.lblGirilenHarfler.Location = new System.Drawing.Point(119, 77);
            this.lblGirilenHarfler.Name = "lblGirilenHarfler";
            this.lblGirilenHarfler.Size = new System.Drawing.Size(0, 17);
            this.lblGirilenHarfler.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Hak:";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(109, 116);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(16, 17);
            this.lblKalanHak.TabIndex = 7;
            this.lblKalanHak.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOyunAlanı);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOyunAlanı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGirilenHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnHarfGir;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button btnYeniOyun;
    }
}

