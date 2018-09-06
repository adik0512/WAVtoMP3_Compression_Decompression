using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace WAVtoMP3_Compression_Decompression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonInFileWav_Click(object sender, EventArgs e)
        {
            if (textBoxSample.Text == "")
            {
                DialogResult dr = MessageBox.Show("Need more data !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.OK:
                        break;
                }
            }
            else if (textBoxSample.Text == "0")
            {
                DialogResult dr = MessageBox.Show("Sample must be different from 0 !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.OK:
                        break;
                }
            }
            else
            {
                double sample = double.Parse(textBoxSample.Text);
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave File (*.wav)|*.wav;";
                if (open.ShowDialog() != DialogResult.OK) return;

                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Series.Add("wave");
                chart1.Series["wave"].Color = Color.Red;
                chart1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["wave"].ChartArea = "ChartArea1";
                //chart1.ChartAreas["ChartArea1"].AxisY.Minimum = -1;
                //chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
                this.chart1.Titles.Add("WAV Oryginal");

                NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));

                byte[] buffer = new byte[16384];
                int read = 0;

                while (wave.Position < wave.Length)
                {
                    read = wave.Read(buffer, 0, 16384);

                    for (int i = 0; i < read / sample; i++)
                    {
                        chart1.Series["wave"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                    }
                }
                textBoxInFileWave.Text = open.FileName;
                textBoxOutFileWave.Text = System.IO.Path.ChangeExtension(textBoxInFileWave.Text, ".mp3");
            }
        }

        private void buttonCompressWav_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "MP3 File (*.mp3)|*.mp3;";
            if (save.ShowDialog() != DialogResult.OK) return;

            using (var reader = new NAudio.Wave.AudioFileReader(textBoxInFileWave.Text))
            using (var writer = new NAudio.Lame.LameMP3FileWriter(save.FileName, reader.WaveFormat, NAudio.Lame.LAMEPreset.STANDARD))
            {
                reader.CopyTo(writer);
            }
        }

        private void buttonInFileMP3_Click(object sender, EventArgs e)
        {
            if (textBoxSample.Text == "")
            {
                DialogResult dr = MessageBox.Show("Need more data !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.OK:
                        break;
                }
            }
            else if (textBoxSample.Text == "0")
            {
                DialogResult dr = MessageBox.Show("Sample must be different from 0 !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.OK:
                        break;
                }
            }
            else
            {
                double sample = double.Parse(textBoxSample.Text);
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "MP3 File (*.mp3)|*.mp3;";
                if (open.ShowDialog() != DialogResult.OK) return;

                chart2.Series.Clear();
                chart2.Titles.Clear();
                chart2.Series.Add("mp3");
                chart2.Series["mp3"].Color = Color.Red;
                chart2.Series["mp3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart2.Series["mp3"].ChartArea = "ChartArea1";
                //chart2.ChartAreas["ChartArea1"].AxisY.Minimum = -1;
                //chart2.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
                this.chart2.Titles.Add("MP3 Compressed");

                NAudio.Wave.WaveChannel32 mp3 = new NAudio.Wave.WaveChannel32(new NAudio.Wave.Mp3FileReader(open.FileName));

                byte[] buffer = new byte[16384];
                int read = 0;

                while (mp3.Position < mp3.Length)
                {
                    read = mp3.Read(buffer, 0, 16384);

                    for (int i = 0; i < read / sample; i++)
                    {
                        chart2.Series["mp3"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                    }
                }
                textBoxInFileMP3.Text = open.FileName;
                textBoxOutFileMP3.Text = System.IO.Path.ChangeExtension(textBoxInFileMP3.Text, ".wav");
            }
        }

        private void buttonCompressMP3_Click(object sender, EventArgs e)
        {
            if (textBoxSample.Text == "")
            {
                DialogResult dr = MessageBox.Show("Need more data !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.OK:
                        break;
                }
            }
            else if (textBoxSample.Text == "0")
            {
                DialogResult dr = MessageBox.Show("Sample must be different from 0 !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.OK:
                        break;
                }
            }
            else
            {
                double sample = double.Parse(textBoxSample.Text);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "WAV File (*.wav)|*.wav;";
                if (save.ShowDialog() != DialogResult.OK) return;

                using (Mp3FileReader mp3 = new Mp3FileReader(textBoxInFileMP3.Text))
                {
                    using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                    {
                        WaveFileWriter.CreateWaveFile(save.FileName, pcm);
                    }
                }

                chart3.Series.Clear();
                chart3.Titles.Clear();
                chart3.Series.Add("wave");
                chart3.Series["wave"].Color = Color.Red;
                chart3.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart3.Series["wave"].ChartArea = "ChartArea1";
                //chart3.ChartAreas["ChartArea1"].AxisY.Minimum = -1;
                //chart3.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
                this.chart3.Titles.Add("WAV Decompressed");

                NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(save.FileName));

                byte[] buffer = new byte[16384];
                int read = 0;

                while (wave.Position < wave.Length)
                {
                    read = wave.Read(buffer, 0, 16384);

                    for (int i = 0; i < read / sample; i++)
                    {
                        chart3.Series["wave"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                    }
                }
            }
        }      
    }
}