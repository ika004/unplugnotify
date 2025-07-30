using Microsoft.Win32;
using System.Diagnostics;

namespace unplugnotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int debugint = 0;



        private void allowrdnoti_CheckedChanged(object sender, EventArgs e)
        {
            if(allowrdnoti.Checked)
            {
                Chktim.Start();
                Chktim.Enabled = true;
            }
            else
            {
                Chktim.Enabled = false;
            }
        }


        private void Chktim_Tick(object sender, EventArgs e)
        {
            PowerLineStatus powerLineStatus = SystemInformation.PowerStatus.PowerLineStatus;

            debugint++;
            
            
            debugtext.Text =debugint.ToString();
            switch (powerLineStatus)
            {
                case PowerLineStatus.Online:
                    Btchk.Text = "オンライン";
                    Btchk.ForeColor = Color.Aqua;
                    break;
                case PowerLineStatus.Offline:
                    if (allowrdnoti.Checked && Chktim.Enabled)
                    {
                        noti form2 = new noti();
                        Chktim.Stop();
                        form2.ShowDialog();
                        Chktim.Start();

                    }
                    Btchk.Text = "オフライン";
                    Btchk.ForeColor = Color.Red;
                    break;

                    default:
                    Btchk.Text = "loading...";
                    break;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
             Chktim.Start();
        }
    }
}
