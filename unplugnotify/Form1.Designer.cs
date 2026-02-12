namespace unplugnotify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            allowrdnoti = new CheckBox();
            Chktim = new System.Windows.Forms.Timer(components);
            Btchk = new Label();
            debugtext = new Label();
            ScreenChange = new CheckBox();
            SuspendLayout();
            // 
            // allowrdnoti
            // 
            allowrdnoti.AutoSize = true;
            allowrdnoti.Checked = true;
            allowrdnoti.CheckState = CheckState.Checked;
            allowrdnoti.Location = new Point(357, 189);
            allowrdnoti.Name = "allowrdnoti";
            allowrdnoti.Size = new Size(88, 19);
            allowrdnoti.TabIndex = 0;
            allowrdnoti.Text = "allowednoti";
            allowrdnoti.UseVisualStyleBackColor = true;
            allowrdnoti.CheckedChanged += allowrdnoti_CheckedChanged;
            // 
            // Chktim
            // 
            Chktim.Interval = 1000;
            Chktim.Tick += Chktim_Tick;
            // 
            // Btchk
            // 
            Btchk.AutoSize = true;
            Btchk.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Btchk.Location = new Point(231, 52);
            Btchk.Name = "Btchk";
            Btchk.Size = new Size(82, 30);
            Btchk.TabIndex = 1;
            Btchk.Text = "loading";
            // 
            // debugtext
            // 
            debugtext.AutoSize = true;
            debugtext.Location = new Point(42, 167);
            debugtext.Name = "debugtext";
            debugtext.Size = new Size(38, 15);
            debugtext.TabIndex = 2;
            debugtext.Text = "label1";
            // 
            // ScreenChange
            // 
            ScreenChange.AutoSize = true;
            ScreenChange.Location = new Point(357, 119);
            ScreenChange.Name = "ScreenChange";
            ScreenChange.Size = new Size(98, 19);
            ScreenChange.TabIndex = 3;
            ScreenChange.Text = "表示画面変更";
            ScreenChange.UseVisualStyleBackColor = true;
            ScreenChange.CheckedChanged += ScreenChange_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(457, 220);
            Controls.Add(ScreenChange);
            Controls.Add(debugtext);
            Controls.Add(Btchk);
            Controls.Add(allowrdnoti);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "電源管理";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox allowrdnoti;
        private System.Windows.Forms.Timer Chktim;
        private Label Btchk;
        private Label debugtext;
        private CheckBox ScreenChange;
    }
}
