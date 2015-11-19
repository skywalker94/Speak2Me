using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;
using System.IO;

namespace Speak2Me
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss;
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetorno, int MciRetornoLeng, int CallBack);

        string musica = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recording.Visible = false;
            female.Checked = true;
            ss = new SpeechSynthesizer();
        }

        private void record_Click(object sender, EventArgs e)
        {
            standby.Visible = false;
            recording.Visible = true;
            play.Enabled = false;
            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            recording.Visible = false;
            standby.Visible = true;
            play.Enabled = true;
            mciSendString("pause Som", null, 0, 0);



            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "wave|*.wav";


            if (save.ShowDialog() == DialogResult.OK)
            {

                mciSendString("save Som " + save.FileName, null, 0, 0);
                mciSendString("close Som", null, 0, 0);
                mciSendString("close Som", null, 0, 0);
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave|*.wav";
                if (open.ShowDialog() == DialogResult.OK) { musica = open.FileName; }
            
            mciSendString("play " + musica, null, 0, 0);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            if (male.Checked == true)
            {
                ss.SelectVoiceByHints(VoiceGender.Male);
            }
            else
            {
                ss.SelectVoiceByHints(VoiceGender.Female);
            }
            ss.Rate = rateBar.Value;
            ss.Volume = rateBar.Value;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Wave Files| *.wav";
            sfd.ShowDialog();
            ss.SetOutputToWaveFile(sfd.FileName);
            ss.Speak(textBox.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Recording Complete", "Report");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void speak_Click(object sender, EventArgs e)
        {
            ss.Rate = rateBar.Value;
            ss.Volume = volumeBar.Value;
            //ss.Voice = ;
            if (male.Checked == true) 
            {
                ss.SelectVoiceByHints(VoiceGender.Male);
            }
            else
            {
                ss.SelectVoiceByHints(VoiceGender.Female);
            }
            ss.SpeakAsync(textBox.Text);
        }

        private void pause_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }

        private void resume_Click(object sender, EventArgs e)
        {
            ss.Resume();
        }
    }
}
