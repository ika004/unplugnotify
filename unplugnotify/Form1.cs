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
            if (allowrdnoti.Checked)
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

            noti form2 = new noti(this);
            noti_g form3 = new noti_g(this);

            debugtext.Text = debugint.ToString();
            switch (powerLineStatus)
            {
                case PowerLineStatus.Online:


                    Btchk.Text = "オンライン";
                    arrowedp = true;
                    Btchk.ForeColor = Color.Aqua;
                    form2.Close();


                    break;
                case PowerLineStatus.Offline:
                    if (allowrdnoti.Checked && Chktim.Enabled)
                    {
                        if (iswindowopen == false && arrowedp == true)
                        {
                            if(ScreenChange.Checked)
                            {
                                form3.Show();
                                iswindowopen = true;
                                form3.FormClosed += (s, args) => { iswindowopen = false; };
                            }
                            else
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

        private void ScreenChange_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
