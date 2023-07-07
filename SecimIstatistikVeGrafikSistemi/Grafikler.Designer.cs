namespace SecimIstatistikVeGrafikSistemi
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblceviz = new System.Windows.Forms.Label();
            this.lblkivi = new System.Windows.Forms.Label();
            this.lbllimon = new System.Windows.Forms.Label();
            this.lblkarpuz = new System.Windows.Forms.Label();
            this.lblmuz = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 23);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Partiler";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(806, 213);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblceviz);
            this.groupBox2.Controls.Add(this.lblkivi);
            this.groupBox2.Controls.Add(this.lbllimon);
            this.groupBox2.Controls.Add(this.lblkarpuz);
            this.groupBox2.Controls.Add(this.lblmuz);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblceviz
            // 
            this.lblceviz.AutoSize = true;
            this.lblceviz.Location = new System.Drawing.Point(495, 221);
            this.lblceviz.Name = "lblceviz";
            this.lblceviz.Size = new System.Drawing.Size(18, 19);
            this.lblceviz.TabIndex = 21;
            this.lblceviz.Text = "0";
            // 
            // lblkivi
            // 
            this.lblkivi.AutoSize = true;
            this.lblkivi.Location = new System.Drawing.Point(495, 188);
            this.lblkivi.Name = "lblkivi";
            this.lblkivi.Size = new System.Drawing.Size(18, 19);
            this.lblkivi.TabIndex = 20;
            this.lblkivi.Text = "0";
            // 
            // lbllimon
            // 
            this.lbllimon.AutoSize = true;
            this.lbllimon.Location = new System.Drawing.Point(495, 155);
            this.lbllimon.Name = "lbllimon";
            this.lbllimon.Size = new System.Drawing.Size(18, 19);
            this.lbllimon.TabIndex = 19;
            this.lbllimon.Text = "0";
            // 
            // lblkarpuz
            // 
            this.lblkarpuz.AutoSize = true;
            this.lblkarpuz.Location = new System.Drawing.Point(495, 122);
            this.lblkarpuz.Name = "lblkarpuz";
            this.lblkarpuz.Size = new System.Drawing.Size(18, 19);
            this.lblkarpuz.TabIndex = 18;
            this.lblkarpuz.Text = "0";
            // 
            // lblmuz
            // 
            this.lblmuz.AutoSize = true;
            this.lblmuz.Location = new System.Drawing.Point(495, 89);
            this.lblmuz.Name = "lblmuz";
            this.lblmuz.Size = new System.Drawing.Size(18, 19);
            this.lblmuz.TabIndex = 17;
            this.lblmuz.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ceviz PARTİSİ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kivi PARTİSİ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Limon PARTİSİ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Karpuz PARTİSİ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Muz PARTİSİ:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(277, 217);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(212, 27);
            this.progressBar5.TabIndex = 11;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(277, 184);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(212, 27);
            this.progressBar4.TabIndex = 9;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(277, 151);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(212, 27);
            this.progressBar3.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(277, 118);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(212, 27);
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(277, 85);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(277, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçim:";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(818, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Sistemi";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblceviz;
        private System.Windows.Forms.Label lblkivi;
        private System.Windows.Forms.Label lbllimon;
        private System.Windows.Forms.Label lblkarpuz;
        private System.Windows.Forms.Label lblmuz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}