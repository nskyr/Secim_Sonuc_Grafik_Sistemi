
namespace Secim_Sonuc_Grafik_Sistemi
{
    partial class frmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpBoxGrafikler = new System.Windows.Forms.GroupBox();
            this.chartSecimSonuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDparti = new System.Windows.Forms.Label();
            this.lblCparti = new System.Windows.Forms.Label();
            this.lblBparti = new System.Windows.Forms.Label();
            this.lblAparti = new System.Windows.Forms.Label();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxIlce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxGrafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecimSonuc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGrafikler
            // 
            this.grpBoxGrafikler.Controls.Add(this.chartSecimSonuc);
            this.grpBoxGrafikler.Location = new System.Drawing.Point(12, 12);
            this.grpBoxGrafikler.Name = "grpBoxGrafikler";
            this.grpBoxGrafikler.Size = new System.Drawing.Size(1199, 326);
            this.grpBoxGrafikler.TabIndex = 0;
            this.grpBoxGrafikler.TabStop = false;
            this.grpBoxGrafikler.Text = "Grafikler";
            // 
            // chartSecimSonuc
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSecimSonuc.ChartAreas.Add(chartArea1);
            this.chartSecimSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSecimSonuc.Legends.Add(legend1);
            this.chartSecimSonuc.Location = new System.Drawing.Point(3, 30);
            this.chartSecimSonuc.Name = "chartSecimSonuc";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chartSecimSonuc.Series.Add(series1);
            this.chartSecimSonuc.Size = new System.Drawing.Size(1193, 293);
            this.chartSecimSonuc.TabIndex = 0;
            this.chartSecimSonuc.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.lblDparti);
            this.groupBox1.Controls.Add(this.lblCparti);
            this.groupBox1.Controls.Add(this.lblBparti);
            this.groupBox1.Controls.Add(this.lblAparti);
            this.groupBox1.Controls.Add(this.progressBarD);
            this.groupBox1.Controls.Add(this.progressBarC);
            this.groupBox1.Controls.Add(this.progressBarB);
            this.groupBox1.Controls.Add(this.progressBarA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBoxIlce);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlçeler";
            // 
            // lblDparti
            // 
            this.lblDparti.AutoSize = true;
            this.lblDparti.Location = new System.Drawing.Point(857, 183);
            this.lblDparti.Name = "lblDparti";
            this.lblDparti.Size = new System.Drawing.Size(24, 27);
            this.lblDparti.TabIndex = 13;
            this.lblDparti.Text = "0";
            // 
            // lblCparti
            // 
            this.lblCparti.AutoSize = true;
            this.lblCparti.Location = new System.Drawing.Point(857, 136);
            this.lblCparti.Name = "lblCparti";
            this.lblCparti.Size = new System.Drawing.Size(24, 27);
            this.lblCparti.TabIndex = 12;
            this.lblCparti.Text = "0";
            // 
            // lblBparti
            // 
            this.lblBparti.AutoSize = true;
            this.lblBparti.Location = new System.Drawing.Point(857, 86);
            this.lblBparti.Name = "lblBparti";
            this.lblBparti.Size = new System.Drawing.Size(24, 27);
            this.lblBparti.TabIndex = 11;
            this.lblBparti.Text = "0";
            // 
            // lblAparti
            // 
            this.lblAparti.AutoSize = true;
            this.lblAparti.Location = new System.Drawing.Point(857, 36);
            this.lblAparti.Name = "lblAparti";
            this.lblAparti.Size = new System.Drawing.Size(24, 27);
            this.lblAparti.TabIndex = 10;
            this.lblAparti.Text = "0";
            // 
            // progressBarD
            // 
            this.progressBarD.Location = new System.Drawing.Point(504, 183);
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(347, 27);
            this.progressBarD.TabIndex = 9;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(504, 136);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(347, 27);
            this.progressBarC.TabIndex = 8;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(504, 86);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(347, 27);
            this.progressBarB.TabIndex = 7;
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(504, 36);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(347, 27);
            this.progressBarA.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "D Parti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "C Parti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "B Parti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // cmbBoxIlce
            // 
            this.cmbBoxIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxIlce.FormattingEnabled = true;
            this.cmbBoxIlce.Location = new System.Drawing.Point(154, 98);
            this.cmbBoxIlce.Name = "cmbBoxIlce";
            this.cmbBoxIlce.Size = new System.Drawing.Size(217, 34);
            this.cmbBoxIlce.TabIndex = 1;
            this.cmbBoxIlce.SelectedIndexChanged += new System.EventHandler(this.cmbBoxIlce_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // frmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1223, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxGrafikler);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.frmGrafikler_Load);
            this.grpBoxGrafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSecimSonuc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGrafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSecimSonuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxIlce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarD;
        private System.Windows.Forms.Label lblDparti;
        private System.Windows.Forms.Label lblCparti;
        private System.Windows.Forms.Label lblBparti;
        private System.Windows.Forms.Label lblAparti;
    }
}