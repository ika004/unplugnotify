using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace unplugnotify
{
    public partial class noti : Form
    {
        bool soundstoped = false;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        

        public noti()
        {
            InitializeComponent();
        }

        private async void Btcls_Click(object sender, EventArgs e)
        {
          //  player.controls.stop();
            
            player.URL = @"c:\sound\POS\POS_touch.mp3";
            
            if (soundstoped == false)
            {
               await  Task.Delay(200);
                player.settings.setMode("loop", true);
                player.URL = @"c:\sound\POS\houchi.mp3";
                Btcls.Text = "確認";
                soundstoped = true;
            }
            else if (soundstoped == true)
            {
                await Task.Delay(200 );
                soundstoped = false;
                Close();
                player.controls.stop();
            }
        }

        private void noti_Shown(object sender, EventArgs e)
        {

            timer1.Start();
            player.settings.setMode("loop", true);
            player.URL = @"c:\sound\POS\critical.mp3";
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
    }
}
