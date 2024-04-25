using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;

namespace NetSpeakLite
{
    public partial class Form1 : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();

        public List<VoiceData> voiceDataList = new List<VoiceData>();
        public class VoiceData
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Age { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            RefreshVoiceList();

            synth.Volume = 100;
            synth.Rate = 0;
        }

        private void GetEngineList()
        {
            ReadOnlyCollection<InstalledVoice> voicelist = synth.GetInstalledVoices();
            foreach (InstalledVoice voice in voicelist)
            {
                VoiceInfo info = voice.VoiceInfo;
                //Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}", info.Name, info.Gender, info.Age);
                voiceDataList.Add(new VoiceData { Name = info.Name, Gender = info.Gender.ToString(), Age = info.Age.ToString()});
            }
        }

        private void RefreshVoiceList()
        {
            GetEngineList();

            comboBoxVoiceList.Items.Clear();
            foreach (VoiceData voice in voiceDataList)
            {
                comboBoxVoiceList.Items.Add(voice.Name);
            }
            comboBoxVoiceList.SelectedIndex = 0;
        }

        private void buttonSpeak_Click(object sender, EventArgs e)
        {
            synth.Speak(textBox1.Text);
        }

        private void comboBoxVoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            synth.SelectVoice(voiceDataList.Find(x => x.Name == comboBoxVoiceList.SelectedItem.ToString()).Name);
        }

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void numericUpDownVolume_ValueChanged(object sender, EventArgs e)
        {
            synth.Volume = (int)numericUpDownVolume.Value;
        }

        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            synth.Rate = (int)numericUpDownSpeed.Value;
        }

        private void comboBoxQuick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQuick.SelectedIndex < 0)
            {
                return;
            }
            synth.Speak(comboBoxQuick.SelectedItem.ToString());
            comboBoxQuick.SelectedIndex = -1;
        }
    }
}
