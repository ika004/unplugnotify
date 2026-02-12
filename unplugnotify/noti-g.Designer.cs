namespace unplugnotify
{
    partial class noti_g
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            octime = new Label();
            label7 = new Label();
            Btcls = new Button();
            disablenoti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "ERROR Occurred :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(84, 99);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "CODE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(159, 99);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "E001";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(84, 144);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "NAME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(160, 144);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 4;
            label5.Text = "電源供給異常 １";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(84, 188);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "TIME:";
            // 
            // octime
            // 
            octime.AutoSize = true;
            octime.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            octime.ForeColor = SystemColors.ButtonHighlight;
            octime.Location = new Point(160, 188);
            octime.Name = "octime";
            octime.Size = new Size(202, 20);
            octime.TabIndex = 6;
            octime.Text = "2026/02/12 16:32:00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS UI Gothic", 15F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(84, 256);
            label7.Name = "label7";
            label7.Size = new Size(446, 80);
            label7.TabIndex = 7;
            label7.Text = "電源供給部でエラーが発生しています。\r\n電源供給部を確認してください。\r\nエラー解除確認後、解除ボタンを押してください。\r\nエラーが確認できない場合、再起動を行ってください。";
            // 
            // Btcls
            // 
            Btcls.BackColor = SystemColors.ActiveCaptionText;
            Btcls.ForeColor = SystemColors.ButtonFace;
            Btcls.Location = new Point(84, 408);
            Btcls.Name = "Btcls";
            Btcls.Size = new Size(103, 64);
            Btcls.TabIndex = 8;
            Btcls.Text = "消音/解除";
            Btcls.UseVisualStyleBackColor = false;
            Btcls.Click += Btcls_Click;
            // 
            // disablenoti
            // 
            disablenoti.BackColor = SystemColors.ActiveCaptionText;
            disablenoti.ForeColor = SystemColors.ButtonFace;
            disablenoti.Location = new Point(227, 408);
            disablenoti.Name = "disablenoti";
            disablenoti.Size = new Size(103, 64);
            disablenoti.TabIndex = 9;
            disablenoti.Text = "エラー無効・解除";
            disablenoti.UseVisualStyleBackColor = false;
            disablenoti.Click += disablenoti_Click;
            // 
            // noti_g
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1264, 761);
            Controls.Add(disablenoti);
            Controls.Add(Btcls);
            Controls.Add(label7);
            Controls.Add(octime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "noti_g";
            Text = "noti_g";
            WindowState = FormWindowState.Maximized;
            Load += noti_g_Load;
            Shown += noti_g_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label octime;
        private Label label7;
        private Button Btcls;
        private Button disablenoti;
    }
}