using AxWMPLib;
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
    public partial class noti : Form
    {
        private Form1 _parentform;

        

        bool soundstoped = false;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        SoundPlayer Scritical = new SoundPlayer(Resources.critical);
        SoundPlayer touch = new SoundPlayer(Resources.touch);
        SoundPlayer houchi = new SoundPlayer(Resources.houchi);


        public noti(Form1 parentform)
        {
            InitializeComponent();
            _parentform = parentform;
        }

        private async void Btcls_Click(object sender, EventArgs e)
        {
            //  player.controls.stop();

            //player.URL = @"c:\sound\POS\POS_touch.mp3";
            touch.Play();

            if (soundstoped == false)
            {
                await Task.Delay(200);
                //player.settings.setMode("loop", true);
                //player.URL = @"c:\sound\POS\houchi.mp3";
                houchi.PlayLooping();
                Btcls.Text = "確認";
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
        }

        private void noti_Shown(object sender, EventArgs e)
        {

            timer1.Start();
            // player.settings.setMode("loop", true);
            //player.URL = @"c:\sound\POS\critical.mp3";
            Scritical.PlayLooping();
            Btcls.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            PowerLineStatus powerLineStatus = SystemInformation.PowerStatus.PowerLineStatus;
            if (powerLineStatus == PowerLineStatus.Online)
            {
                soundstoped = false;
                Close();
                player.controls.stop();
            }
            */

        }

        private void disablenoti_Click(object sender, EventArgs e)
        {
            _parentform.arrowedp = false;
            touch.Play();
            Close();
        }
    }
}
