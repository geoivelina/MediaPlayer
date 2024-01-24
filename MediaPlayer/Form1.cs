using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.uiMode = "None";
        }
        string[] paths, files;

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[TrackList.SelectedIndex];
            Player.Ctlcontrols.play();
            MediaPlayerLable.Text = "Playing...";
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
            MediaPlayerLable.Text = "Playing...";
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
            MediaPlayerLable.Text = "Pause";
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = open.SafeFileNames;
                paths = open.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    TrackList.Items.Add(files[i]);
                }
            }
        }
    }
}
