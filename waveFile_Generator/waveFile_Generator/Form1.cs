using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace waveFile_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genSinWave_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                WaveGenerator waveGen = new WaveGenerator(WaveExampleType.ExampleSineWave);
                waveGen.Save(openFileDialog1.FileName);

                SoundPlayer player = new SoundPlayer(openFileDialog1.FileName);
                player.Play();
            }
        }
    }
}
