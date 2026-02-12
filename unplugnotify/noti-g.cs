using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unplugnotify.Properties;
using WMPLib;

namespace unplugnotify
{
    public partial class noti_g : Form
    {

        private Form1 _parentform;
        public noti_g(Form1 parentform)
        {
            InitializeComponent();
            _parentform = parentform;
        }

        bool soundstoped = false;
        SoundPlayer touch = new SoundPlayer(Resources.touch);
        SoundPlayer ES1 = new SoundPlayer(Resources.Error_S1);
        SoundPlayer ES2 = new SoundPlayer(Resources.Error_conami);


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void noti_g_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            octime.Text = now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void noti_g_Shown(object sender, EventArgs e)
        {
            //original

            //ES1.PlayLooping();

            //conami

            ES2.PlayLooping();
        }

        private async void Btcls_Click(object sender, EventArgs e)
        {
            ES1.Stop();
            ES2.Stop();
            if (soundstoped == false)
            {
                await Task.Delay(200);
                //player.settings.setMode("loop", true);
                //player.URL = @"c:\sound\POS\houchi.mp3";
                Btcls.Text = "解除";
                disablenoti.Visible = true;
                soundstoped = true;
            }
            else if (soundstoped == true)
            {
                await Task.Delay(200);
                soundstoped = false;
                Close();
                // player.controls.stop();
            }
            
            touch.Play();
            //Close();
        }

        private void disablenoti_Click(object sender, EventArgs e)
        {
            _parentform.arrowedp = false;
            touch.Play();
            Close();
        }
    }
}
