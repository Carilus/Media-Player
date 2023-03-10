using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carilus_Media_Player
{
    public partial class CarilusMusicPlayer : Form
    {
        string[] path, files;
        public CarilusMusicPlayer()
        {
            InitializeComponent();
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[Songs.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Songs.Items.Clear();
            Array.Clear(path, 0, path.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                path = ofd.FileNames;
                for(int i = 0;i<files.Length;i++)
                {
                    Songs.Items.Add(files[i]);
                }
            }
        }
    }
}
