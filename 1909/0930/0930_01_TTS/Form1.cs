using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Speech.Synthesis;

namespace _0930_01_TTS
{
    public partial class Form1 : Form
    {
        private int _speechRate = 0;
        private int _speechVolume = 50;

        public Form1()
        {
            InitializeComponent();

            lblRate.Text = _speechRate.ToString(CultureInfo.InvariantCulture);
            lblVolume.Text = _speechVolume.ToString(CultureInfo.InvariantCulture);

            AddInstalledVoicesToList();
        }

        private void AddInstalledVoicesToList()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    ddlVoices.Items.Add(voice.VoiceInfo.Name);
                }
            }

            ddlVoices.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SpeechSynthesizer synth = new SpeechSynthesizer())
            //{
            //    //synth.Speak("Hello World");
            //    synth.Speak(textBox1.Text);
            //}

            if (string.IsNullOrEmpty(txtTextToSpeak.Text))
            {
                MessageBox.Show("Please enter some text in the text box before trying to speak");
                return;
            }

            using (SpeechSynthesizer synth = new SpeechSynthesizer
            {
                Volume = _speechVolume,
                Rate = _speechRate
            })
            {
                synth.SelectVoice(ddlVoices.Text);
                synth.Speak(txtTextToSpeak.Text);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _speechRate = trackBar1.Value;
            lblRate.Text = _speechRate.ToString(CultureInfo.InvariantCulture);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            _speechVolume = trackBar2.Value;
            lblVolume.Text = _speechVolume.ToString(CultureInfo.InvariantCulture);
        }
    }
}
