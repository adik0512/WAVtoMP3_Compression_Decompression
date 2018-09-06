namespace WAVtoMP3_Compression_Decompression
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.buttonCompressWav = new System.Windows.Forms.Button();
            this.buttonInFileWav = new System.Windows.Forms.Button();
            this.textBoxOutFileWave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInFileWave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDecompressMP3 = new System.Windows.Forms.Button();
            this.buttonInFileMP3 = new System.Windows.Forms.Button();
            this.textBoxOutFileMP3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInFileMP3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCompressWav
            // 
            this.buttonCompressWav.Location = new System.Drawing.Point(270, 72);
            this.buttonCompressWav.Name = "buttonCompressWav";
            this.buttonCompressWav.Size = new System.Drawing.Size(75, 23);
            this.buttonCompressWav.TabIndex = 16;
            this.buttonCompressWav.Text = "Compress";
            this.buttonCompressWav.Click += new System.EventHandler(this.buttonCompressWav_Click);
            // 
            // buttonInFileWav
            // 
            this.buttonInFileWav.Location = new System.Drawing.Point(270, 32);
            this.buttonInFileWav.Name = "buttonInFileWav";
            this.buttonInFileWav.Size = new System.Drawing.Size(75, 23);
            this.buttonInFileWav.TabIndex = 13;
            this.buttonInFileWav.Text = "Browse...";
            this.buttonInFileWav.Click += new System.EventHandler(this.buttonInFileWav_Click);
            // 
            // textBoxOutFileWave
            // 
            this.textBoxOutFileWave.Enabled = false;
            this.textBoxOutFileWave.Location = new System.Drawing.Point(6, 72);
            this.textBoxOutFileWave.Name = "textBoxOutFileWave";
            this.textBoxOutFileWave.ReadOnly = true;
            this.textBoxOutFileWave.Size = new System.Drawing.Size(256, 20);
            this.textBoxOutFileWave.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Compressed file:";
            // 
            // textBoxInFileWave
            // 
            this.textBoxInFileWave.Location = new System.Drawing.Point(6, 32);
            this.textBoxInFileWave.Name = "textBoxInFileWave";
            this.textBoxInFileWave.ReadOnly = true;
            this.textBoxInFileWave.Size = new System.Drawing.Size(256, 20);
            this.textBoxInFileWave.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wave file:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Location = new System.Drawing.Point(2, 109);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(942, 300);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            this.chart2.Location = new System.Drawing.Point(2, 415);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(942, 300);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // buttonDecompressMP3
            // 
            this.buttonDecompressMP3.Location = new System.Drawing.Point(613, 72);
            this.buttonDecompressMP3.Name = "buttonDecompressMP3";
            this.buttonDecompressMP3.Size = new System.Drawing.Size(75, 23);
            this.buttonDecompressMP3.TabIndex = 24;
            this.buttonDecompressMP3.Text = "Decompress";
            this.buttonDecompressMP3.Click += new System.EventHandler(this.buttonCompressMP3_Click);
            // 
            // buttonInFileMP3
            // 
            this.buttonInFileMP3.Location = new System.Drawing.Point(613, 30);
            this.buttonInFileMP3.Name = "buttonInFileMP3";
            this.buttonInFileMP3.Size = new System.Drawing.Size(75, 23);
            this.buttonInFileMP3.TabIndex = 23;
            this.buttonInFileMP3.Text = "Browse...";
            this.buttonInFileMP3.Click += new System.EventHandler(this.buttonInFileMP3_Click);
            // 
            // textBoxOutFileMP3
            // 
            this.textBoxOutFileMP3.Enabled = false;
            this.textBoxOutFileMP3.Location = new System.Drawing.Point(351, 72);
            this.textBoxOutFileMP3.Name = "textBoxOutFileMP3";
            this.textBoxOutFileMP3.ReadOnly = true;
            this.textBoxOutFileMP3.Size = new System.Drawing.Size(256, 20);
            this.textBoxOutFileMP3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(351, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Compressed file:";
            // 
            // textBoxInFileMP3
            // 
            this.textBoxInFileMP3.Location = new System.Drawing.Point(351, 32);
            this.textBoxInFileMP3.Name = "textBoxInFileMP3";
            this.textBoxInFileMP3.ReadOnly = true;
            this.textBoxInFileMP3.Size = new System.Drawing.Size(256, 20);
            this.textBoxInFileMP3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(351, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "MP3 file:";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            this.chart3.Location = new System.Drawing.Point(2, 721);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(942, 300);
            this.chart3.TabIndex = 25;
            this.chart3.Text = "chart3";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxOptions.Controls.Add(this.label5);
            this.groupBoxOptions.Controls.Add(this.textBoxSample);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.textBoxInFileWave);
            this.groupBoxOptions.Controls.Add(this.buttonDecompressMP3);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.buttonInFileMP3);
            this.groupBoxOptions.Controls.Add(this.textBoxOutFileWave);
            this.groupBoxOptions.Controls.Add(this.textBoxOutFileMP3);
            this.groupBoxOptions.Controls.Add(this.buttonInFileWav);
            this.groupBoxOptions.Controls.Add(this.label3);
            this.groupBoxOptions.Controls.Add(this.buttonCompressWav);
            this.groupBoxOptions.Controls.Add(this.textBoxInFileMP3);
            this.groupBoxOptions.Controls.Add(this.label4);
            this.groupBoxOptions.Location = new System.Drawing.Point(44, 3);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(805, 100);
            this.groupBoxOptions.TabIndex = 26;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options:";
            // 
            // textBoxSample
            // 
            this.textBoxSample.Location = new System.Drawing.Point(694, 32);
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.Size = new System.Drawing.Size(100, 20);
            this.textBoxSample.TabIndex = 26;
            this.textBoxSample.Text = "1024";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(694, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sample:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 415);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "WAV to MP3 Compression & Decompression";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCompressWav;
        private System.Windows.Forms.Button buttonInFileWav;
        private System.Windows.Forms.TextBox textBoxOutFileWave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInFileWave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button buttonDecompressMP3;
        private System.Windows.Forms.Button buttonInFileMP3;
        private System.Windows.Forms.TextBox textBoxOutFileMP3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInFileMP3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSample;
    }
}

