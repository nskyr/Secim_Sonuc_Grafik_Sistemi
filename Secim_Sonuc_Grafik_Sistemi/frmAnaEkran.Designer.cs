
namespace Secim_Sonuc_Grafik_Sistemi
{
    partial class frmAnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlceAdi = new System.Windows.Forms.TextBox();
            this.txtAparti = new System.Windows.Forms.TextBox();
            this.txtBparti = new System.Windows.Forms.TextBox();
            this.txtCparti = new System.Windows.Forms.TextBox();
            this.txtDparti = new System.Windows.Forms.TextBox();
            this.btnOyGirisi = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "A Parti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "B Parti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "C Parti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "D Parti:";
            // 
            // txtIlceAdi
            // 
            this.txtIlceAdi.Location = new System.Drawing.Point(196, 51);
            this.txtIlceAdi.Name = "txtIlceAdi";
            this.txtIlceAdi.Size = new System.Drawing.Size(281, 34);
            this.txtIlceAdi.TabIndex = 5;
            // 
            // txtAparti
            // 
            this.txtAparti.Location = new System.Drawing.Point(196, 109);
            this.txtAparti.Name = "txtAparti";
            this.txtAparti.Size = new System.Drawing.Size(281, 34);
            this.txtAparti.TabIndex = 6;
            // 
            // txtBparti
            // 
            this.txtBparti.Location = new System.Drawing.Point(196, 168);
            this.txtBparti.Name = "txtBparti";
            this.txtBparti.Size = new System.Drawing.Size(281, 34);
            this.txtBparti.TabIndex = 7;
            // 
            // txtCparti
            // 
            this.txtCparti.Location = new System.Drawing.Point(196, 223);
            this.txtCparti.Name = "txtCparti";
            this.txtCparti.Size = new System.Drawing.Size(281, 34);
            this.txtCparti.TabIndex = 8;
            // 
            // txtDparti
            // 
            this.txtDparti.Location = new System.Drawing.Point(196, 273);
            this.txtDparti.Name = "txtDparti";
            this.txtDparti.Size = new System.Drawing.Size(281, 34);
            this.txtDparti.TabIndex = 9;
            // 
            // btnOyGirisi
            // 
            this.btnOyGirisi.Location = new System.Drawing.Point(196, 313);
            this.btnOyGirisi.Name = "btnOyGirisi";
            this.btnOyGirisi.Size = new System.Drawing.Size(281, 50);
            this.btnOyGirisi.TabIndex = 10;
            this.btnOyGirisi.Text = "Oy Girişi Yap";
            this.btnOyGirisi.UseVisualStyleBackColor = true;
            this.btnOyGirisi.Click += new System.EventHandler(this.btnOyGirisi_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Location = new System.Drawing.Point(196, 369);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(139, 50);
            this.btnGrafikler.TabIndex = 11;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(341, 369);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(136, 50);
            this.btnCikisYap.TabIndex = 12;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(593, 519);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnGrafikler);
            this.Controls.Add(this.btnOyGirisi);
            this.Controls.Add(this.txtDparti);
            this.Controls.Add(this.txtCparti);
            this.Controls.Add(this.txtBparti);
            this.Controls.Add(this.txtAparti);
            this.Controls.Add(this.txtIlceAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAnaEkran";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIlceAdi;
        private System.Windows.Forms.TextBox txtAparti;
        private System.Windows.Forms.TextBox txtBparti;
        private System.Windows.Forms.TextBox txtCparti;
        private System.Windows.Forms.TextBox txtDparti;
        private System.Windows.Forms.Button btnOyGirisi;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnCikisYap;
    }
}

