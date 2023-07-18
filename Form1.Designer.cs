namespace ROBOT_WINFORM
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
            label1 = new Label();
            TxtIpRobot = new TextBox();
            BtnConRobot = new Button();
            TxtData = new TextBox();
            BtnClear = new Button();
            label3 = new Label();
            label2 = new Label();
            TxtPortRobot = new TextBox();
            BtnDisRobot = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtIpCam = new TextBox();
            TxtPortCam = new TextBox();
            BtnConCam = new Button();
            BtnDisCam = new Button();
            label7 = new Label();
            label8 = new Label();
            TxtX = new TextBox();
            label9 = new Label();
            TxtY = new TextBox();
            label10 = new Label();
            TxtZ = new TextBox();
            label11 = new Label();
            TxtRx = new TextBox();
            label12 = new Label();
            TxtRy = new TextBox();
            label13 = new Label();
            TxtRz = new TextBox();
            BtnAutoCal = new Button();
            BtnGetCurPos = new Button();
            BtnMovePos = new Button();
            label15 = new Label();
            label16 = new Label();
            TxtPortCamR = new TextBox();
            BtnConCamR = new Button();
            label17 = new Label();
            TxtCommand = new TextBox();
            BtnSentCam = new Button();
            TxtCommandR = new TextBox();
            BtnSendR = new Button();
            label18 = new Label();
            TxtF = new TextBox();
            BtnDisCamR = new Button();
            Setting = new TabControl();
            tabPage1 = new TabPage();
            DownRz = new Button();
            button12 = new Button();
            DownRX = new Button();
            DownZ = new Button();
            DownY = new Button();
            DownX = new Button();
            button2 = new Button();
            UpRz = new Button();
            button11 = new Button();
            UpRx = new Button();
            UpZ = new Button();
            UpY = new Button();
            UpX = new Button();
            button1 = new Button();
            StepRz = new TextBox();
            StepRy = new TextBox();
            StepRx = new TextBox();
            StepZ = new TextBox();
            StepY = new TextBox();
            StepX = new TextBox();
            label19 = new Label();
            label14 = new Label();
            tabPage2 = new TabPage();
            Setting.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // TxtIpRobot
            // 
            TxtIpRobot.Location = new Point(44, 37);
            TxtIpRobot.Multiline = true;
            TxtIpRobot.Name = "TxtIpRobot";
            TxtIpRobot.Size = new Size(119, 23);
            TxtIpRobot.TabIndex = 1;
            TxtIpRobot.Text = "192.168.1.30";
            // 
            // BtnConRobot
            // 
            BtnConRobot.Location = new Point(174, 37);
            BtnConRobot.Name = "BtnConRobot";
            BtnConRobot.Size = new Size(75, 23);
            BtnConRobot.TabIndex = 2;
            BtnConRobot.Text = "Connect";
            BtnConRobot.UseVisualStyleBackColor = true;
            BtnConRobot.Click += BtnConRobot_Click;
            // 
            // TxtData
            // 
            TxtData.Enabled = false;
            TxtData.ImeMode = ImeMode.On;
            TxtData.Location = new Point(342, 157);
            TxtData.MinimumSize = new Size(10, 10);
            TxtData.Multiline = true;
            TxtData.Name = "TxtData";
            TxtData.ScrollBars = ScrollBars.Vertical;
            TxtData.Size = new Size(345, 328);
            TxtData.TabIndex = 1;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(612, 491);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 2;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 12);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Robot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "PORT";
            // 
            // TxtPortRobot
            // 
            TxtPortRobot.Location = new Point(44, 66);
            TxtPortRobot.Multiline = true;
            TxtPortRobot.Name = "TxtPortRobot";
            TxtPortRobot.Size = new Size(119, 23);
            TxtPortRobot.TabIndex = 1;
            TxtPortRobot.Text = "5001";
            // 
            // BtnDisRobot
            // 
            BtnDisRobot.Location = new Point(174, 66);
            BtnDisRobot.Name = "BtnDisRobot";
            BtnDisRobot.Size = new Size(75, 23);
            BtnDisRobot.TabIndex = 2;
            BtnDisRobot.Text = "Disconect";
            BtnDisRobot.UseVisualStyleBackColor = true;
            BtnDisRobot.Click += BtnDisRobot_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 41);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 0;
            label4.Text = "IP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, -21);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "AS200";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 71);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 0;
            label6.Text = "PORT";
            // 
            // TxtIpCam
            // 
            TxtIpCam.Location = new Point(424, 38);
            TxtIpCam.Multiline = true;
            TxtIpCam.Name = "TxtIpCam";
            TxtIpCam.Size = new Size(134, 23);
            TxtIpCam.TabIndex = 1;
            TxtIpCam.Text = "192.168.1.10";
            // 
            // TxtPortCam
            // 
            TxtPortCam.Location = new Point(424, 67);
            TxtPortCam.Multiline = true;
            TxtPortCam.Name = "TxtPortCam";
            TxtPortCam.Size = new Size(134, 23);
            TxtPortCam.TabIndex = 1;
            TxtPortCam.Text = "5001";
            // 
            // BtnConCam
            // 
            BtnConCam.Location = new Point(574, 38);
            BtnConCam.Name = "BtnConCam";
            BtnConCam.Size = new Size(75, 23);
            BtnConCam.TabIndex = 2;
            BtnConCam.Text = "Connect";
            BtnConCam.UseVisualStyleBackColor = true;
            BtnConCam.Click += BtnConCam_Click;
            // 
            // BtnDisCam
            // 
            BtnDisCam.Location = new Point(574, 67);
            BtnDisCam.Name = "BtnDisCam";
            BtnDisCam.Size = new Size(75, 23);
            BtnDisCam.TabIndex = 2;
            BtnDisCam.Text = "Disconect";
            BtnDisCam.UseVisualStyleBackColor = true;
            BtnDisCam.Click += BtnDisCam_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 153);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 0;
            label7.Text = "X";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 132);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 0;
            label8.Text = "Current Position";
            // 
            // TxtX
            // 
            TxtX.Location = new Point(46, 150);
            TxtX.Multiline = true;
            TxtX.Name = "TxtX";
            TxtX.Size = new Size(93, 23);
            TxtX.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 182);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 0;
            label9.Text = "Y";
            // 
            // TxtY
            // 
            TxtY.Location = new Point(44, 179);
            TxtY.Multiline = true;
            TxtY.Name = "TxtY";
            TxtY.Size = new Size(93, 23);
            TxtY.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 211);
            label10.Name = "label10";
            label10.Size = new Size(14, 15);
            label10.TabIndex = 0;
            label10.Text = "Z";
            // 
            // TxtZ
            // 
            TxtZ.Location = new Point(44, 208);
            TxtZ.Multiline = true;
            TxtZ.Name = "TxtZ";
            TxtZ.Size = new Size(93, 23);
            TxtZ.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 240);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 0;
            label11.Text = "Rx";
            // 
            // TxtRx
            // 
            TxtRx.Location = new Point(44, 237);
            TxtRx.Multiline = true;
            TxtRx.Name = "TxtRx";
            TxtRx.Size = new Size(93, 23);
            TxtRx.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 269);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 0;
            label12.Text = "Ry";
            // 
            // TxtRy
            // 
            TxtRy.Location = new Point(44, 266);
            TxtRy.Multiline = true;
            TxtRy.Name = "TxtRy";
            TxtRy.Size = new Size(93, 23);
            TxtRy.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 298);
            label13.Name = "label13";
            label13.Size = new Size(19, 15);
            label13.TabIndex = 0;
            label13.Text = "Rz";
            // 
            // TxtRz
            // 
            TxtRz.Location = new Point(44, 295);
            TxtRz.Multiline = true;
            TxtRz.Name = "TxtRz";
            TxtRz.Size = new Size(93, 23);
            TxtRz.TabIndex = 1;
            // 
            // BtnAutoCal
            // 
            BtnAutoCal.Location = new Point(143, 353);
            BtnAutoCal.Name = "BtnAutoCal";
            BtnAutoCal.Size = new Size(144, 23);
            BtnAutoCal.TabIndex = 2;
            BtnAutoCal.Text = "Auto calibration";
            BtnAutoCal.UseVisualStyleBackColor = true;
            BtnAutoCal.Click += BtnAutoCal_Click;
            // 
            // BtnGetCurPos
            // 
            BtnGetCurPos.Location = new Point(46, 353);
            BtnGetCurPos.Name = "BtnGetCurPos";
            BtnGetCurPos.Size = new Size(88, 23);
            BtnGetCurPos.TabIndex = 2;
            BtnGetCurPos.Text = "Get CurPos";
            BtnGetCurPos.UseVisualStyleBackColor = true;
            BtnGetCurPos.Click += BtnGetCurPos_Click;
            // 
            // BtnMovePos
            // 
            BtnMovePos.Location = new Point(143, 324);
            BtnMovePos.Name = "BtnMovePos";
            BtnMovePos.Size = new Size(144, 23);
            BtnMovePos.TabIndex = 2;
            BtnMovePos.Text = "Move Pos";
            BtnMovePos.UseVisualStyleBackColor = true;
            BtnMovePos.Click += BtnMovePos_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(397, 499);
            label15.Name = "label15";
            label15.Size = new Size(80, 15);
            label15.TabIndex = 0;
            label15.Text = " AS200 Recipe";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(342, 521);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 0;
            label16.Text = "PORT";
            // 
            // TxtPortCamR
            // 
            TxtPortCamR.Location = new Point(383, 520);
            TxtPortCamR.Multiline = true;
            TxtPortCamR.Name = "TxtPortCamR";
            TxtPortCamR.Size = new Size(110, 23);
            TxtPortCamR.TabIndex = 1;
            TxtPortCamR.Text = "23";
            // 
            // BtnConCamR
            // 
            BtnConCamR.Location = new Point(499, 521);
            BtnConCamR.Name = "BtnConCamR";
            BtnConCamR.Size = new Size(86, 23);
            BtnConCamR.TabIndex = 2;
            BtnConCamR.Text = "Connect";
            BtnConCamR.UseVisualStyleBackColor = true;
            BtnConCamR.Click += BtnConCamR_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(445, 110);
            label17.Name = "label17";
            label17.Size = new Size(99, 15);
            label17.TabIndex = 0;
            label17.Text = "Command AS200";
            // 
            // TxtCommand
            // 
            TxtCommand.Location = new Point(342, 128);
            TxtCommand.Multiline = true;
            TxtCommand.Name = "TxtCommand";
            TxtCommand.Size = new Size(264, 23);
            TxtCommand.TabIndex = 1;
            // 
            // BtnSentCam
            // 
            BtnSentCam.Location = new Point(612, 128);
            BtnSentCam.Name = "BtnSentCam";
            BtnSentCam.Size = new Size(75, 23);
            BtnSentCam.TabIndex = 2;
            BtnSentCam.Text = "Send";
            BtnSentCam.UseVisualStyleBackColor = true;
            BtnSentCam.Click += BtnSentCam_Click;
            // 
            // TxtCommandR
            // 
            TxtCommandR.Location = new Point(342, 550);
            TxtCommandR.Multiline = true;
            TxtCommandR.Name = "TxtCommandR";
            TxtCommandR.Size = new Size(264, 23);
            TxtCommandR.TabIndex = 1;
            // 
            // BtnSendR
            // 
            BtnSendR.Location = new Point(612, 550);
            BtnSendR.Name = "BtnSendR";
            BtnSendR.Size = new Size(75, 23);
            BtnSendR.TabIndex = 2;
            BtnSendR.Text = "Send";
            BtnSendR.UseVisualStyleBackColor = true;
            BtnSendR.Click += BtnSendR_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(24, 327);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 0;
            label18.Text = "F";
            // 
            // TxtF
            // 
            TxtF.Location = new Point(44, 324);
            TxtF.Multiline = true;
            TxtF.Name = "TxtF";
            TxtF.Size = new Size(93, 23);
            TxtF.TabIndex = 1;
            // 
            // BtnDisCamR
            // 
            BtnDisCamR.Location = new Point(591, 520);
            BtnDisCamR.Name = "BtnDisCamR";
            BtnDisCamR.Size = new Size(96, 23);
            BtnDisCamR.TabIndex = 2;
            BtnDisCamR.Text = "Disconect";
            BtnDisCamR.UseVisualStyleBackColor = true;
            BtnDisCamR.Click += BtnDisCamR_Click;
            // 
            // Setting
            // 
            Setting.Controls.Add(tabPage1);
            Setting.Controls.Add(tabPage2);
            Setting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Setting.Location = new Point(3, 6);
            Setting.Name = "Setting";
            Setting.SelectedIndex = 0;
            Setting.Size = new Size(717, 612);
            Setting.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(TxtData);
            tabPage1.Controls.Add(DownRz);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(DownRX);
            tabPage1.Controls.Add(DownZ);
            tabPage1.Controls.Add(DownY);
            tabPage1.Controls.Add(DownX);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(UpRz);
            tabPage1.Controls.Add(button11);
            tabPage1.Controls.Add(UpRx);
            tabPage1.Controls.Add(UpZ);
            tabPage1.Controls.Add(UpY);
            tabPage1.Controls.Add(UpX);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(BtnDisRobot);
            tabPage1.Controls.Add(BtnClear);
            tabPage1.Controls.Add(BtnMovePos);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(BtnAutoCal);
            tabPage1.Controls.Add(BtnSendR);
            tabPage1.Controls.Add(BtnGetCurPos);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(BtnConRobot);
            tabPage1.Controls.Add(BtnSentCam);
            tabPage1.Controls.Add(TxtPortRobot);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(TxtF);
            tabPage1.Controls.Add(BtnDisCamR);
            tabPage1.Controls.Add(TxtRz);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(TxtRy);
            tabPage1.Controls.Add(BtnDisCam);
            tabPage1.Controls.Add(TxtRx);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(TxtZ);
            tabPage1.Controls.Add(TxtY);
            tabPage1.Controls.Add(TxtIpCam);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(BtnConCam);
            tabPage1.Controls.Add(StepRz);
            tabPage1.Controls.Add(StepRy);
            tabPage1.Controls.Add(StepRx);
            tabPage1.Controls.Add(StepZ);
            tabPage1.Controls.Add(StepY);
            tabPage1.Controls.Add(StepX);
            tabPage1.Controls.Add(TxtX);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(TxtPortCamR);
            tabPage1.Controls.Add(TxtIpRobot);
            tabPage1.Controls.Add(TxtPortCam);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(TxtCommand);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(BtnConCamR);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(TxtCommandR);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(709, 584);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Setting";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DownRz
            // 
            DownRz.Location = new Point(254, 295);
            DownRz.Name = "DownRz";
            DownRz.Size = new Size(33, 23);
            DownRz.TabIndex = 2;
            DownRz.Text = "-";
            DownRz.UseVisualStyleBackColor = true;
            DownRz.Click += BtnDisRobot_Click;
            // 
            // button12
            // 
            button12.Location = new Point(254, 266);
            button12.Name = "button12";
            button12.Size = new Size(33, 23);
            button12.TabIndex = 2;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BtnDisRobot_Click;
            // 
            // DownRX
            // 
            DownRX.Location = new Point(254, 237);
            DownRX.Name = "DownRX";
            DownRX.Size = new Size(33, 23);
            DownRX.TabIndex = 2;
            DownRX.Text = "-";
            DownRX.UseVisualStyleBackColor = true;
            DownRX.Click += BtnDisRobot_Click;
            // 
            // DownZ
            // 
            DownZ.Location = new Point(254, 208);
            DownZ.Name = "DownZ";
            DownZ.Size = new Size(33, 23);
            DownZ.TabIndex = 2;
            DownZ.Text = "-";
            DownZ.UseVisualStyleBackColor = true;
            DownZ.Click += BtnDisRobot_Click;
            // 
            // DownY
            // 
            DownY.Location = new Point(254, 179);
            DownY.Name = "DownY";
            DownY.Size = new Size(33, 23);
            DownY.TabIndex = 2;
            DownY.Text = "-";
            DownY.UseVisualStyleBackColor = true;
            DownY.Click += BtnDisRobot_Click;
            // 
            // DownX
            // 
            DownX.Location = new Point(254, 150);
            DownX.Name = "DownX";
            DownX.Size = new Size(33, 23);
            DownX.TabIndex = 2;
            DownX.Text = "-";
            DownX.UseVisualStyleBackColor = true;
            DownX.Click += BtnDisRobot_Click;
            // 
            // button2
            // 
            button2.Location = new Point(254, 150);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnDisRobot_Click;
            // 
            // UpRz
            // 
            UpRz.Location = new Point(215, 295);
            UpRz.Name = "UpRz";
            UpRz.Size = new Size(33, 23);
            UpRz.TabIndex = 2;
            UpRz.Text = "+";
            UpRz.UseVisualStyleBackColor = true;
            UpRz.Click += BtnDisRobot_Click;
            // 
            // button11
            // 
            button11.Location = new Point(215, 266);
            button11.Name = "button11";
            button11.Size = new Size(33, 23);
            button11.TabIndex = 2;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BtnDisRobot_Click;
            // 
            // UpRx
            // 
            UpRx.Location = new Point(215, 237);
            UpRx.Name = "UpRx";
            UpRx.Size = new Size(33, 23);
            UpRx.TabIndex = 2;
            UpRx.Text = "+";
            UpRx.UseVisualStyleBackColor = true;
            UpRx.Click += BtnDisRobot_Click;
            // 
            // UpZ
            // 
            UpZ.Location = new Point(215, 208);
            UpZ.Name = "UpZ";
            UpZ.Size = new Size(33, 23);
            UpZ.TabIndex = 2;
            UpZ.Text = "+";
            UpZ.UseVisualStyleBackColor = true;
            UpZ.Click += BtnDisRobot_Click;
            // 
            // UpY
            // 
            UpY.Location = new Point(215, 179);
            UpY.Name = "UpY";
            UpY.Size = new Size(33, 23);
            UpY.TabIndex = 2;
            UpY.Text = "+";
            UpY.UseVisualStyleBackColor = true;
            UpY.Click += BtnDisRobot_Click;
            // 
            // UpX
            // 
            UpX.Location = new Point(215, 150);
            UpX.Name = "UpX";
            UpX.Size = new Size(33, 23);
            UpX.TabIndex = 2;
            UpX.Text = "+";
            UpX.UseVisualStyleBackColor = true;
            UpX.MouseDown += UpX_MouseDown;
            // 
            // button1
            // 
            button1.Location = new Point(215, 150);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnDisRobot_Click;
            // 
            // StepRz
            // 
            StepRz.Location = new Point(143, 294);
            StepRz.Multiline = true;
            StepRz.Name = "StepRz";
            StepRz.Size = new Size(65, 23);
            StepRz.TabIndex = 1;
            StepRz.Text = "2";
            StepRz.TextAlign = HorizontalAlignment.Center;
            // 
            // StepRy
            // 
            StepRy.Location = new Point(143, 266);
            StepRy.Multiline = true;
            StepRy.Name = "StepRy";
            StepRy.Size = new Size(65, 23);
            StepRy.TabIndex = 1;
            StepRy.Text = "2";
            StepRy.TextAlign = HorizontalAlignment.Center;
            // 
            // StepRx
            // 
            StepRx.Location = new Point(143, 237);
            StepRx.Multiline = true;
            StepRx.Name = "StepRx";
            StepRx.Size = new Size(65, 23);
            StepRx.TabIndex = 1;
            StepRx.Text = "2";
            StepRx.TextAlign = HorizontalAlignment.Center;
            // 
            // StepZ
            // 
            StepZ.Location = new Point(143, 208);
            StepZ.Multiline = true;
            StepZ.Name = "StepZ";
            StepZ.Size = new Size(65, 23);
            StepZ.TabIndex = 1;
            StepZ.Text = "3";
            StepZ.TextAlign = HorizontalAlignment.Center;
            // 
            // StepY
            // 
            StepY.Location = new Point(143, 179);
            StepY.Multiline = true;
            StepY.Name = "StepY";
            StepY.Size = new Size(65, 23);
            StepY.TabIndex = 1;
            StepY.Text = "3";
            StepY.TextAlign = HorizontalAlignment.Center;
            // 
            // StepX
            // 
            StepX.Location = new Point(143, 150);
            StepX.Multiline = true;
            StepX.Name = "StepX";
            StepX.Size = new Size(65, 23);
            StepX.TabIndex = 1;
            StepX.Text = "3";
            StepX.TextAlign = HorizontalAlignment.Center;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(143, 131);
            label19.Name = "label19";
            label19.Size = new Size(63, 15);
            label19.TabIndex = 0;
            label19.Text = "Step move";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(445, 13);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 0;
            label14.Text = "Camera AS200";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(725, 589);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 616);
            Controls.Add(Setting);
            Name = "Form1";
            Text = "Form1";
            Setting.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TxtIpRobot;
        private Button BtnConRobot;
        public TextBox TxtData;
        private Button BtnClear;
        private Label label3;
        private Label label2;
        private TextBox TxtPortRobot;
        private Button BtnDisRobot;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtIpCam;
        private TextBox TxtPortCam;
        private Button BtnConCam;
        private Button BtnDisCam;
        private Label label7;
        private Label label8;
        private TextBox TxtX;
        private Label label9;
        private TextBox TxtY;
        private Label label10;
        private TextBox TxtZ;
        private Label label11;
        private TextBox TxtRx;
        private Label label12;
        private TextBox TxtRy;
        private Label label13;
        private TextBox TxtRz;
        private Button BtnAutoCal;
        private Button BtnGetCurPos;
        private Button BtnMovePos;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox12;
        private TextBox TxtPortCamR;
        private Button BtnConCamR;
        private Button DownRX;
        private Label label17;
        private TextBox TxtCommand;
        private Button BtnSentCam;
        private TextBox TxtCommandR;
        private Button BtnSendR;
        private Label label18;
        private TextBox TxtF;
        private Button BtnDisCamR;
        private TabControl Setting;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button DownRz;
        private Button button12;
        private Button DownZ;
        private Button DownY;
        private Button DownX;
        private Button button2;
        private Button UpRz;
        private Button button11;
        private Button UpRx;
        private Button UpZ;
        private Button UpY;
        private Button UpX;
        private TextBox StepRz;
        private TextBox StepRy;
        private TextBox StepRx;
        private TextBox StepZ;
        private TextBox StepY;
        private TextBox StepX;
        private Label label19;
    }
}