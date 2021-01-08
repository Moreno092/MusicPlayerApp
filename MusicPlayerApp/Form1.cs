using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //array för spår och fil
        string[] path, files;

        private void btbSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Kunna välja flera filer
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                path = ofd.FileNames;
                //Kunna lägga in en fil
                for (int i = 0; i < files.Length; i++)
                {
                    SongList.Items.Add(files[i]);
                }
            }

        }

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kod för att spela musik
            WindowsMediaPlayerMusic.URL = path[SongList.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
