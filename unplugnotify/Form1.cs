using Microsoft.Win32;
using System.Diagnostics;

namespace unplugnotify
{
 
    public partial class Form1 : Form
    {
        bool iswindowopen = false;
        public bool arrowedp;


        public Form1()
        {
            InitializeComponent();
            
        }

        int debugint = 0;



        public void allowrdnoti_CheckedChanged(object sender, EventArgs e)
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
            arrowedp = allowrdnoti.Checked;
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
                    arrowedp = true;    
                    Btchk.ForeColor = Color.Aqua;

                    

                    break;
                case PowerLineStatus.Offline:
                    if (allowrdnoti.Checked && Chktim.Enabled)
                    {
                        noti form2 = new noti(this);
                        if (iswindowopen == false && arrowedp == true)
                        {
                            form2.Show();
                            iswindowopen = true;
                            form2.FormClosed += (s, args) => { iswindowopen = false; };
                        }
                        

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
            arrowedp = true;
             Chktim.Start();
        }
    }
}
