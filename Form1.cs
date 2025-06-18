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
using static System.Net.Mime.MediaTypeNames;
using NAudio.Wave;
using System.IO;
using NAudio.Wave.SampleProviders;
using System.Diagnostics;

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

        private void Speak(String text)
        {
            listBoxTextLog.Items.Add(text);
            listBoxTextLog.SelectedIndex = listBoxTextLog.Items.Count - 1;
            DoSpeak(text);
        }

        private void DoSpeak(string text)
        {
            //将音频输出至内存流
            MemoryStream ms = new MemoryStream();
            synth.SetOutputToWaveStream(ms);
            //执行朗读
            synth.Speak(text);
            //重置内存流位置
            ms.Position = 0;
            //使用NAudio提升音量
            var waveProvider = new WaveFileReader(ms);
            var sampleProvider = new Pcm16BitToSampleProvider(waveProvider);
            var volumeProvider = new VolumeSampleProvider(sampleProvider)
            {
                Volume = (float)numericUpDownVolNA.Value
            };
            using (var waveOutEvent = new WaveOutEvent())
            {
                waveOutEvent.Init(volumeProvider);
                waveOutEvent.Play();
                while (waveOutEvent.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void buttonSpeak_Click(object sender, EventArgs e)
        {
            Speak(textBox1.Text);
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
            Speak(comboBoxQuick.SelectedItem.ToString());
            comboBoxQuick.SelectedIndex = -1;
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            listBoxTextLog.Items.Clear();
        }

        private void listBoxTextLog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoSpeak(listBoxTextLog.Text);
        }
    }
}
