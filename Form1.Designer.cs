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
            DownZ = new Button();
            DownY = new Button();
            DownX = new Button();
            button2 = new Button();
            UpRz = new Button();
            UpZ = new Button();
            UpY = new Button();
            UpX = new Button();
            button1 = new Button();
            BtnMovePosTrigger = new Button();
            BtnMovePick = new Button();
            BtnTriggerPick = new Button();
            BtnTrainPosTrigger = new Button();
            BtnTraningPick = new Button();
            TextPartRuntime = new TextBox();
            TxtPart = new TextBox();
            StepRz = new TextBox();
            StepZ = new TextBox();
            StepY = new TextBox();
            StepX = new TextBox();
            label23 = new Label();
            label20 = new Label();
            label19 = new Label();
            label22 = new Label();
            label14 = new Label();
            label21 = new Label();
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
            TxtData.Location = new Point(348, 151);
            TxtData.MinimumSize = new Size(10, 10);
            TxtData.Multiline = true;
            TxtData.Name = "TxtData";
            TxtData.ScrollBars = ScrollBars.Vertical;
            TxtData.Size = new Size(345, 328);
            TxtData.TabIndex = 1;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(618, 485);
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
            TxtPortRobot.TextChanged += TxtPortRobot_TextChanged;
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
            label7.Location = new Point(17, 124);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 0;
            label7.Text = "X";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 103);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 0;
            label8.Text = "Current Position";
            // 
            // TxtX
            // 
            TxtX.Location = new Point(39, 121);
            TxtX.Multiline = true;
            TxtX.Name = "TxtX";
            TxtX.Size = new Size(93, 23);
            TxtX.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 153);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 0;
            label9.Text = "Y";
            // 
            // TxtY
            // 
            TxtY.Location = new Point(37, 150);
            TxtY.Multiline = true;
            TxtY.Name = "TxtY";
            TxtY.Size = new Size(93, 23);
            TxtY.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 182);
            label10.Name = "label10";
            label10.Size = new Size(14, 15);
            label10.TabIndex = 0;
            label10.Text = "Z";
            // 
            // TxtZ
            // 
            TxtZ.Location = new Point(37, 179);
            TxtZ.Multiline = true;
            TxtZ.Name = "TxtZ";
            TxtZ.Size = new Size(93, 23);
            TxtZ.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 269);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 0;
            label11.Text = "Rx";
            // 
            // TxtRx
            // 
            TxtRx.Location = new Point(37, 266);
            TxtRx.Multiline = true;
            TxtRx.Name = "TxtRx";
            TxtRx.Size = new Size(93, 23);
            TxtRx.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 240);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 0;
            label12.Text = "Ry";
            // 
            // TxtRy
            // 
            TxtRy.Location = new Point(37, 237);
            TxtRy.Multiline = true;
            TxtRy.Name = "TxtRy";
            TxtRy.Size = new Size(93, 23);
            TxtRy.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 211);
            label13.Name = "label13";
            label13.Size = new Size(19, 15);
            label13.TabIndex = 0;
            label13.Text = "Rz";
            // 
            // TxtRz
            // 
            TxtRz.Location = new Point(37, 208);
            TxtRz.Multiline = true;
            TxtRz.Name = "TxtRz";
            TxtRz.Size = new Size(93, 23);
            TxtRz.TabIndex = 1;
            // 
            // BtnAutoCal
            // 
            BtnAutoCal.Location = new Point(137, 295);
            BtnAutoCal.Name = "BtnAutoCal";
            BtnAutoCal.Size = new Size(144, 23);
            BtnAutoCal.TabIndex = 2;
            BtnAutoCal.Text = "Auto calibration";
            BtnAutoCal.UseVisualStyleBackColor = true;
            BtnAutoCal.Click += BtnAutoCal_Click;
            // 
            // BtnGetCurPos
            // 
            BtnGetCurPos.Location = new Point(137, 265);
            BtnGetCurPos.Name = "BtnGetCurPos";
            BtnGetCurPos.Size = new Size(144, 23);
            BtnGetCurPos.TabIndex = 2;
            BtnGetCurPos.Text = "Get CurPos";
            BtnGetCurPos.UseVisualStyleBackColor = true;
            BtnGetCurPos.Click += BtnGetCurPos_Click;
            // 
            // BtnMovePos
            // 
            BtnMovePos.Location = new Point(137, 237);
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
            label15.Location = new Point(406, 489);
            label15.Name = "label15";
            label15.Size = new Size(80, 15);
            label15.TabIndex = 0;
            label15.Text = " AS200 Recipe";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(348, 515);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 0;
            label16.Text = "PORT";
            // 
            // TxtPortCamR
            // 
            TxtPortCamR.Location = new Point(389, 514);
            TxtPortCamR.Multiline = true;
            TxtPortCamR.Name = "TxtPortCamR";
            TxtPortCamR.Size = new Size(110, 23);
            TxtPortCamR.TabIndex = 1;
            TxtPortCamR.Text = "23";
            // 
            // BtnConCamR
            // 
            BtnConCamR.Location = new Point(505, 515);
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
            label17.Location = new Point(451, 104);
            label17.Name = "label17";
            label17.Size = new Size(99, 15);
            label17.TabIndex = 0;
            label17.Text = "Command AS200";
            // 
            // TxtCommand
            // 
            TxtCommand.Location = new Point(348, 122);
            TxtCommand.Multiline = true;
            TxtCommand.Name = "TxtCommand";
            TxtCommand.Size = new Size(264, 23);
            TxtCommand.TabIndex = 1;
            // 
            // BtnSentCam
            // 
            BtnSentCam.Location = new Point(618, 122);
            BtnSentCam.Name = "BtnSentCam";
            BtnSentCam.Size = new Size(75, 23);
            BtnSentCam.TabIndex = 2;
            BtnSentCam.Text = "Send";
            BtnSentCam.UseVisualStyleBackColor = true;
            BtnSentCam.Click += BtnSentCam_Click;
            // 
            // TxtCommandR
            // 
            TxtCommandR.Location = new Point(348, 544);
            TxtCommandR.Multiline = true;
            TxtCommandR.Name = "TxtCommandR";
            TxtCommandR.Size = new Size(264, 23);
            TxtCommandR.TabIndex = 1;
            // 
            // BtnSendR
            // 
            BtnSendR.Location = new Point(618, 544);
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
            label18.Location = new Point(18, 298);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 0;
            label18.Text = "F";
            // 
            // TxtF
            // 
            TxtF.Location = new Point(36, 295);
            TxtF.Multiline = true;
            TxtF.Name = "TxtF";
            TxtF.Size = new Size(93, 23);
            TxtF.TabIndex = 1;
            // 
            // BtnDisCamR
            // 
            BtnDisCamR.Location = new Point(597, 514);
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
            Setting.Location = new Point(2, 1);
            Setting.Name = "Setting";
            Setting.SelectedIndex = 0;
            Setting.Size = new Size(721, 615);
            Setting.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(TxtData);
            tabPage1.Controls.Add(DownRz);
            tabPage1.Controls.Add(DownZ);
            tabPage1.Controls.Add(DownY);
            tabPage1.Controls.Add(DownX);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(UpRz);
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
            tabPage1.Controls.Add(BtnMovePosTrigger);
            tabPage1.Controls.Add(BtnMovePick);
            tabPage1.Controls.Add(BtnTriggerPick);
            tabPage1.Controls.Add(BtnTrainPosTrigger);
            tabPage1.Controls.Add(BtnTraningPick);
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
            tabPage1.Controls.Add(TextPartRuntime);
            tabPage1.Controls.Add(BtnConCam);
            tabPage1.Controls.Add(TxtPart);
            tabPage1.Controls.Add(StepRz);
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
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(713, 587);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Setting";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DownRz
            // 
            DownRz.Location = new Point(247, 209);
            DownRz.Name = "DownRz";
            DownRz.Size = new Size(33, 23);
            DownRz.TabIndex = 2;
            DownRz.Text = "-";
            DownRz.UseVisualStyleBackColor = true;
            DownRz.MouseDown += DownRz_MouseDown;
            DownRz.MouseUp += DownRz_MouseUp;
            // 
            // DownZ
            // 
            DownZ.Location = new Point(247, 179);
            DownZ.Name = "DownZ";
            DownZ.Size = new Size(33, 23);
            DownZ.TabIndex = 2;
            DownZ.Text = "-";
            DownZ.UseVisualStyleBackColor = true;
            DownZ.MouseDown += DownZ_MouseDown;
            DownZ.MouseUp += DownZ_MouseUp;
            // 
            // DownY
            // 
            DownY.Location = new Point(247, 150);
            DownY.Name = "DownY";
            DownY.Size = new Size(33, 23);
            DownY.TabIndex = 2;
            DownY.Text = "-";
            DownY.UseVisualStyleBackColor = true;
            DownY.MouseDown += DownY_MouseDown;
            DownY.MouseUp += DownY_MouseUp;
            // 
            // DownX
            // 
            DownX.Location = new Point(247, 121);
            DownX.Name = "DownX";
            DownX.Size = new Size(33, 23);
            DownX.TabIndex = 2;
            DownX.Text = "-";
            DownX.UseVisualStyleBackColor = true;
            DownX.MouseDown += DownX_MouseDown;
            DownX.MouseUp += DownX_MouseUp;
            // 
            // button2
            // 
            button2.Location = new Point(247, 121);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // UpRz
            // 
            UpRz.Location = new Point(209, 209);
            UpRz.Name = "UpRz";
            UpRz.Size = new Size(33, 23);
            UpRz.TabIndex = 2;
            UpRz.Text = "+";
            UpRz.UseVisualStyleBackColor = true;
            UpRz.MouseUp += UpZ_MouseUp;
            // 
            // UpZ
            // 
            UpZ.Location = new Point(208, 179);
            UpZ.Name = "UpZ";
            UpZ.Size = new Size(33, 23);
            UpZ.TabIndex = 2;
            UpZ.Text = "+";
            UpZ.UseVisualStyleBackColor = true;
            UpZ.MouseDown += UpZ_MouseDown;
            UpZ.MouseUp += UpZ_MouseUp;
            // 
            // UpY
            // 
            UpY.Location = new Point(208, 150);
            UpY.Name = "UpY";
            UpY.Size = new Size(33, 23);
            UpY.TabIndex = 2;
            UpY.Text = "+";
            UpY.UseVisualStyleBackColor = true;
            UpY.MouseDown += UpY_MouseDown;
            UpY.MouseUp += UpY_MouseUp;
            // 
            // UpX
            // 
            UpX.Location = new Point(208, 121);
            UpX.Name = "UpX";
            UpX.Size = new Size(33, 23);
            UpX.TabIndex = 2;
            UpX.Text = "+";
            UpX.UseVisualStyleBackColor = true;
            UpX.MouseDown += UpX_MouseDown;
            UpX.MouseUp += UpX_MouseUp;
            // 
            // button1
            // 
            button1.Location = new Point(208, 121);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnMovePosTrigger
            // 
            BtnMovePosTrigger.Location = new Point(86, 494);
            BtnMovePosTrigger.Name = "BtnMovePosTrigger";
            BtnMovePosTrigger.Size = new Size(68, 56);
            BtnMovePosTrigger.TabIndex = 2;
            BtnMovePosTrigger.Text = "Move Pos trigger";
            BtnMovePosTrigger.UseVisualStyleBackColor = true;
            BtnMovePosTrigger.Click += BtnMovePosTrigger_Click;
            // 
            // BtnMovePick
            // 
            BtnMovePick.Location = new Point(248, 494);
            BtnMovePick.Name = "BtnMovePick";
            BtnMovePick.Size = new Size(79, 55);
            BtnMovePick.TabIndex = 2;
            BtnMovePick.Text = "Move to Pick Place";
            BtnMovePick.UseVisualStyleBackColor = true;
            BtnMovePick.Click += BtnMovePick_Click;
            // 
            // BtnTriggerPick
            // 
            BtnTriggerPick.Location = new Point(163, 494);
            BtnTriggerPick.Name = "BtnTriggerPick";
            BtnTriggerPick.Size = new Size(79, 55);
            BtnTriggerPick.TabIndex = 2;
            BtnTriggerPick.Text = "Trigger";
            BtnTriggerPick.UseVisualStyleBackColor = true;
            BtnTriggerPick.Click += BtnTriggerPick_Click;
            // 
            // BtnTrainPosTrigger
            // 
            BtnTrainPosTrigger.Location = new Point(86, 391);
            BtnTrainPosTrigger.Name = "BtnTrainPosTrigger";
            BtnTrainPosTrigger.Size = new Size(68, 56);
            BtnTrainPosTrigger.TabIndex = 2;
            BtnTrainPosTrigger.Text = "Train Trigger Pos";
            BtnTrainPosTrigger.UseVisualStyleBackColor = true;
            BtnTrainPosTrigger.Click += BtnTrainPosTrigger_Click;
            // 
            // BtnTraningPick
            // 
            BtnTraningPick.Location = new Point(163, 392);
            BtnTraningPick.Name = "BtnTraningPick";
            BtnTraningPick.Size = new Size(79, 55);
            BtnTraningPick.TabIndex = 2;
            BtnTraningPick.Text = "Train Pick Place Pos";
            BtnTraningPick.UseVisualStyleBackColor = true;
            BtnTraningPick.Click += BtnTraningPick_Click;
            // 
            // TextPartRuntime
            // 
            TextPartRuntime.Location = new Point(18, 516);
            TextPartRuntime.Multiline = true;
            TextPartRuntime.Name = "TextPartRuntime";
            TextPartRuntime.Size = new Size(50, 23);
            TextPartRuntime.TabIndex = 1;
            TextPartRuntime.Text = "1";
            TextPartRuntime.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtPart
            // 
            TxtPart.Location = new Point(18, 409);
            TxtPart.Multiline = true;
            TxtPart.Name = "TxtPart";
            TxtPart.Size = new Size(50, 23);
            TxtPart.TabIndex = 1;
            TxtPart.Text = "1";
            TxtPart.TextAlign = HorizontalAlignment.Center;
            // 
            // StepRz
            // 
            StepRz.Location = new Point(137, 209);
            StepRz.Multiline = true;
            StepRz.Name = "StepRz";
            StepRz.Size = new Size(65, 23);
            StepRz.TabIndex = 1;
            StepRz.Text = "2";
            StepRz.TextAlign = HorizontalAlignment.Center;
            // 
            // StepZ
            // 
            StepZ.Location = new Point(136, 179);
            StepZ.Multiline = true;
            StepZ.Name = "StepZ";
            StepZ.Size = new Size(65, 23);
            StepZ.TabIndex = 1;
            StepZ.Text = "3";
            StepZ.TextAlign = HorizontalAlignment.Center;
            // 
            // StepY
            // 
            StepY.Location = new Point(136, 150);
            StepY.Multiline = true;
            StepY.Name = "StepY";
            StepY.Size = new Size(65, 23);
            StepY.TabIndex = 1;
            StepY.Text = "3";
            StepY.TextAlign = HorizontalAlignment.Center;
            // 
            // StepX
            // 
            StepX.Location = new Point(136, 121);
            StepX.Multiline = true;
            StepX.Name = "StepX";
            StepX.Size = new Size(65, 23);
            StepX.TabIndex = 1;
            StepX.Text = "3";
            StepX.TextAlign = HorizontalAlignment.Center;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(29, 498);
            label23.Name = "label23";
            label23.Size = new Size(28, 15);
            label23.TabIndex = 0;
            label23.Text = "Part";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(29, 391);
            label20.Name = "label20";
            label20.Size = new Size(28, 15);
            label20.TabIndex = 0;
            label20.Text = "Part";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(136, 102);
            label19.Name = "label19";
            label19.Size = new Size(63, 15);
            label19.TabIndex = 0;
            label19.Text = "Step move";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 476);
            label22.Name = "label22";
            label22.Size = new Size(131, 15);
            label22.TabIndex = 0;
            label22.Text = "Runtime Pick and Place";
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 373);
            label21.Name = "label21";
            label21.Size = new Size(128, 15);
            label21.TabIndex = 0;
            label21.Text = "Training Pick and Place";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(713, 587);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Traning pick place";
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
        private Button DownZ;
        private Button DownY;
        private Button DownX;
        private Button button2;
        private Button UpRz;
        private Button UpZ;
        private Button UpY;
        private Button UpX;
        private TextBox StepRz;
        private TextBox StepZ;
        private TextBox StepY;
        private TextBox StepX;
        private Label label19;
        private TextBox TxtPart;
        private Button BtnTrainPosTrigger;
        private Button BtnTraningPick;
        private Label label20;
        private Label label21;
        private Button BtnPosTrigger;
        private Button BtnTriggerPick;
        private TextBox TextPartRuntime;
        private Label label23;
        private Label label22;
        private Button BtnMovePick;
        private Button BtnMovePosTrigger;
    }
}