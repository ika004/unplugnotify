namespace unplugnotify
{
    partial class noti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Btcls = new Button();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            disablenoti = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // Btcls
            // 
            Btcls.Anchor = AnchorStyles.Bottom;
            Btcls.BackColor = SystemColors.ScrollBar;
            Btcls.Font = new Font("ＭＳ Ｐゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Btcls.Location = new Point(259, 311);
            Btcls.Name = "Btcls";
            Btcls.Size = new Size(147, 56);
            Btcls.TabIndex = 0;
            Btcls.Text = "消音／確認";
            Btcls.UseVisualStyleBackColor = false;
            Btcls.Click += Btcls_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("ＭＳ Ｐゴシック", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(150, 105);
            label1.Name = "label1";
            label1.Size = new Size(358, 24);
            label1.TabIndex = 1;
            label1.Text = "ＡＣアダプターが切断されました。";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("ＭＳ Ｐゴシック", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(138, 162);
            label2.Name = "label2";
            label2.Size = new Size(391, 21);
            label2.TabIndex = 2;
            label2.Text = "ＡＣアダプターの接続を確認してください。";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // disablenoti
            // 
            disablenoti.Anchor = AnchorStyles.Bottom;
            disablenoti.BackColor = SystemColors.InactiveCaption;
            disablenoti.Font = new Font("ＭＳ Ｐゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            disablenoti.Location = new Point(525, 311);
            disablenoti.Name = "disablenoti";
            disablenoti.Size = new Size(147, 56);
            disablenoti.TabIndex = 3;
            disablenoti.Text = "通知無効化";
            disablenoti.UseVisualStyleBackColor = false;
            disablenoti.Visible = false;
            disablenoti.Click += disablenoti_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("ＭＳ Ｐゴシック", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(42, 210);
            label3.Name = "label3";
            label3.Size = new Size(612, 21);
            label3.TabIndex = 4;
            label3.Text = "通知を無効にする場合は、【通知無効化】ボタンを押してください。";
            // 
            // noti
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources._7sc_window;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 389);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(disablenoti);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btcls);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "noti";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "電源通知";
            TopMost = true;
            Shown += noti_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btcls;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button disablenoti;
        private Label label3;
    }
}