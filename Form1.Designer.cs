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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIpRobot = new System.Windows.Forms.TextBox();
            this.BtnConRobot = new System.Windows.Forms.Button();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPortRobot = new System.Windows.Forms.TextBox();
            this.BtnDisRobot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIpCam = new System.Windows.Forms.TextBox();
            this.TxtPortCam = new System.Windows.Forms.TextBox();
            this.BtnConCam = new System.Windows.Forms.Button();
            this.BtnDisCam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtRx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtRy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtRz = new System.Windows.Forms.TextBox();
            this.BtnAutoCal = new System.Windows.Forms.Button();
            this.BtnGetCurPos = new System.Windows.Forms.Button();
            this.BtnMovePos = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPortCamR = new System.Windows.Forms.TextBox();
            this.BtnConCamR = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtCommand = new System.Windows.Forms.TextBox();
            this.BtnSentCam = new System.Windows.Forms.Button();
            this.TxtCommandR = new System.Windows.Forms.TextBox();
            this.BtnSendR = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtF = new System.Windows.Forms.TextBox();
            this.BtnDisCamR = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DownRz = new System.Windows.Forms.Button();
            this.DownZ = new System.Windows.Forms.Button();
            this.DownY = new System.Windows.Forms.Button();
            this.DownX = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UpRz = new System.Windows.Forms.Button();
            this.UpZ = new System.Windows.Forms.Button();
            this.UpY = new System.Windows.Forms.Button();
            this.UpX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMovePosTrigger = new System.Windows.Forms.Button();
            this.BtnMovePick = new System.Windows.Forms.Button();
            this.BtnTriggerPick = new System.Windows.Forms.Button();
            this.BtnTrainTrigger = new System.Windows.Forms.Button();
            this.BtnTraningPick = new System.Windows.Forms.Button();
            this.TextPartRuntime = new System.Windows.Forms.TextBox();
            this.TxtPart = new System.Windows.Forms.TextBox();
            this.StepRz = new System.Windows.Forms.TextBox();
            this.StepZ = new System.Windows.Forms.TextBox();
            this.StepY = new System.Windows.Forms.TextBox();
            this.StepX = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Setting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // TxtIpRobot
            // 
            this.TxtIpRobot.Location = new System.Drawing.Point(44, 37);
            this.TxtIpRobot.Multiline = true;
            this.TxtIpRobot.Name = "TxtIpRobot";
            this.TxtIpRobot.Size = new System.Drawing.Size(119, 23);
            this.TxtIpRobot.TabIndex = 1;
            this.TxtIpRobot.Text = "192.168.1.30";
            // 
            // BtnConRobot
            // 
            this.BtnConRobot.Location = new System.Drawing.Point(174, 37);
            this.BtnConRobot.Name = "BtnConRobot";
            this.BtnConRobot.Size = new System.Drawing.Size(75, 23);
            this.BtnConRobot.TabIndex = 2;
            this.BtnConRobot.Text = "Connect";
            this.BtnConRobot.UseVisualStyleBackColor = true;
            this.BtnConRobot.Click += new System.EventHandler(this.BtnConRobot_Click);
            // 
            // TxtData
            // 
            this.TxtData.Enabled = false;
            this.TxtData.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtData.Location = new System.Drawing.Point(348, 151);
            this.TxtData.MinimumSize = new System.Drawing.Size(10, 10);
            this.TxtData.Multiline = true;
            this.TxtData.Name = "TxtData";
            this.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtData.Size = new System.Drawing.Size(345, 328);
            this.TxtData.TabIndex = 1;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(618, 485);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Robot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "PORT";
            // 
            // TxtPortRobot
            // 
            this.TxtPortRobot.Location = new System.Drawing.Point(44, 66);
            this.TxtPortRobot.Multiline = true;
            this.TxtPortRobot.Name = "TxtPortRobot";
            this.TxtPortRobot.Size = new System.Drawing.Size(119, 23);
            this.TxtPortRobot.TabIndex = 1;
            this.TxtPortRobot.Text = "5001";
            // 
            // BtnDisRobot
            // 
            this.BtnDisRobot.Location = new System.Drawing.Point(174, 66);
            this.BtnDisRobot.Name = "BtnDisRobot";
            this.BtnDisRobot.Size = new System.Drawing.Size(75, 23);
            this.BtnDisRobot.TabIndex = 2;
            this.BtnDisRobot.Text = "Disconect";
            this.BtnDisRobot.UseVisualStyleBackColor = true;
            this.BtnDisRobot.Click += new System.EventHandler(this.BtnDisRobot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, -21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "AS200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "PORT";
            // 
            // TxtIpCam
            // 
            this.TxtIpCam.Location = new System.Drawing.Point(424, 38);
            this.TxtIpCam.Multiline = true;
            this.TxtIpCam.Name = "TxtIpCam";
            this.TxtIpCam.Size = new System.Drawing.Size(134, 23);
            this.TxtIpCam.TabIndex = 1;
            this.TxtIpCam.Text = "192.168.1.10";
            // 
            // TxtPortCam
            // 
            this.TxtPortCam.Location = new System.Drawing.Point(424, 67);
            this.TxtPortCam.Multiline = true;
            this.TxtPortCam.Name = "TxtPortCam";
            this.TxtPortCam.Size = new System.Drawing.Size(134, 23);
            this.TxtPortCam.TabIndex = 1;
            this.TxtPortCam.Text = "5001";
            // 
            // BtnConCam
            // 
            this.BtnConCam.Location = new System.Drawing.Point(574, 38);
            this.BtnConCam.Name = "BtnConCam";
            this.BtnConCam.Size = new System.Drawing.Size(75, 23);
            this.BtnConCam.TabIndex = 2;
            this.BtnConCam.Text = "Connect";
            this.BtnConCam.UseVisualStyleBackColor = true;
            this.BtnConCam.Click += new System.EventHandler(this.BtnConCam_Click);
            // 
            // BtnDisCam
            // 
            this.BtnDisCam.Location = new System.Drawing.Point(574, 67);
            this.BtnDisCam.Name = "BtnDisCam";
            this.BtnDisCam.Size = new System.Drawing.Size(75, 23);
            this.BtnDisCam.TabIndex = 2;
            this.BtnDisCam.Text = "Disconect";
            this.BtnDisCam.UseVisualStyleBackColor = true;
            this.BtnDisCam.Click += new System.EventHandler(this.BtnDisCam_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current Position";
            // 
            // TxtX
            // 
            this.TxtX.Location = new System.Drawing.Point(39, 121);
            this.TxtX.Multiline = true;
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(93, 23);
            this.TxtX.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y";
            // 
            // TxtY
            // 
            this.TxtY.Location = new System.Drawing.Point(37, 150);
            this.TxtY.Multiline = true;
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(93, 23);
            this.TxtY.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Z";
            // 
            // TxtZ
            // 
            this.TxtZ.Location = new System.Drawing.Point(37, 179);
            this.TxtZ.Multiline = true;
            this.TxtZ.Name = "TxtZ";
            this.TxtZ.Size = new System.Drawing.Size(93, 23);
            this.TxtZ.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Rx";
            // 
            // TxtRx
            // 
            this.TxtRx.Location = new System.Drawing.Point(37, 266);
            this.TxtRx.Multiline = true;
            this.TxtRx.Name = "TxtRx";
            this.TxtRx.Size = new System.Drawing.Size(93, 23);
            this.TxtRx.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ry";
            // 
            // TxtRy
            // 
            this.TxtRy.Location = new System.Drawing.Point(37, 237);
            this.TxtRy.Multiline = true;
            this.TxtRy.Name = "TxtRy";
            this.TxtRy.Size = new System.Drawing.Size(93, 23);
            this.TxtRy.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Rz";
            // 
            // TxtRz
            // 
            this.TxtRz.Location = new System.Drawing.Point(37, 208);
            this.TxtRz.Multiline = true;
            this.TxtRz.Name = "TxtRz";
            this.TxtRz.Size = new System.Drawing.Size(93, 23);
            this.TxtRz.TabIndex = 1;
            // 
            // BtnAutoCal
            // 
            this.BtnAutoCal.Location = new System.Drawing.Point(137, 295);
            this.BtnAutoCal.Name = "BtnAutoCal";
            this.BtnAutoCal.Size = new System.Drawing.Size(144, 23);
            this.BtnAutoCal.TabIndex = 2;
            this.BtnAutoCal.Text = "Auto calibration";
            this.BtnAutoCal.UseVisualStyleBackColor = true;
            this.BtnAutoCal.Click += new System.EventHandler(this.BtnAutoCal_Click);
            // 
            // BtnGetCurPos
            // 
            this.BtnGetCurPos.Location = new System.Drawing.Point(137, 265);
            this.BtnGetCurPos.Name = "BtnGetCurPos";
            this.BtnGetCurPos.Size = new System.Drawing.Size(144, 23);
            this.BtnGetCurPos.TabIndex = 2;
            this.BtnGetCurPos.Text = "Get CurPos";
            this.BtnGetCurPos.UseVisualStyleBackColor = true;
            this.BtnGetCurPos.Click += new System.EventHandler(this.BtnGetCurPos_Click);
            // 
            // BtnMovePos
            // 
            this.BtnMovePos.Location = new System.Drawing.Point(137, 237);
            this.BtnMovePos.Name = "BtnMovePos";
            this.BtnMovePos.Size = new System.Drawing.Size(144, 23);
            this.BtnMovePos.TabIndex = 2;
            this.BtnMovePos.Text = "Move Pos";
            this.BtnMovePos.UseVisualStyleBackColor = true;
            this.BtnMovePos.Click += new System.EventHandler(this.BtnMovePos_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = " AS200 Recipe";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 515);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "PORT";
            // 
            // TxtPortCamR
            // 
            this.TxtPortCamR.Location = new System.Drawing.Point(389, 514);
            this.TxtPortCamR.Multiline = true;
            this.TxtPortCamR.Name = "TxtPortCamR";
            this.TxtPortCamR.Size = new System.Drawing.Size(110, 23);
            this.TxtPortCamR.TabIndex = 1;
            this.TxtPortCamR.Text = "23";
            // 
            // BtnConCamR
            // 
            this.BtnConCamR.Location = new System.Drawing.Point(505, 515);
            this.BtnConCamR.Name = "BtnConCamR";
            this.BtnConCamR.Size = new System.Drawing.Size(86, 23);
            this.BtnConCamR.TabIndex = 2;
            this.BtnConCamR.Text = "Connect";
            this.BtnConCamR.UseVisualStyleBackColor = true;
            this.BtnConCamR.Click += new System.EventHandler(this.BtnConCamR_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(451, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Command AS200";
            // 
            // TxtCommand
            // 
            this.TxtCommand.Location = new System.Drawing.Point(348, 122);
            this.TxtCommand.Multiline = true;
            this.TxtCommand.Name = "TxtCommand";
            this.TxtCommand.Size = new System.Drawing.Size(264, 23);
            this.TxtCommand.TabIndex = 1;
            // 
            // BtnSentCam
            // 
            this.BtnSentCam.Location = new System.Drawing.Point(618, 122);
            this.BtnSentCam.Name = "BtnSentCam";
            this.BtnSentCam.Size = new System.Drawing.Size(75, 23);
            this.BtnSentCam.TabIndex = 2;
            this.BtnSentCam.Text = "Send";
            this.BtnSentCam.UseVisualStyleBackColor = true;
            this.BtnSentCam.Click += new System.EventHandler(this.BtnSentCam_Click);
            // 
            // TxtCommandR
            // 
            this.TxtCommandR.Location = new System.Drawing.Point(348, 544);
            this.TxtCommandR.Multiline = true;
            this.TxtCommandR.Name = "TxtCommandR";
            this.TxtCommandR.Size = new System.Drawing.Size(264, 23);
            this.TxtCommandR.TabIndex = 1;
            // 
            // BtnSendR
            // 
            this.BtnSendR.Location = new System.Drawing.Point(618, 544);
            this.BtnSendR.Name = "BtnSendR";
            this.BtnSendR.Size = new System.Drawing.Size(75, 23);
            this.BtnSendR.TabIndex = 2;
            this.BtnSendR.Text = "Send";
            this.BtnSendR.UseVisualStyleBackColor = true;
            this.BtnSendR.Click += new System.EventHandler(this.BtnSendR_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 298);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "F";
            // 
            // TxtF
            // 
            this.TxtF.Location = new System.Drawing.Point(36, 295);
            this.TxtF.Multiline = true;
            this.TxtF.Name = "TxtF";
            this.TxtF.Size = new System.Drawing.Size(93, 23);
            this.TxtF.TabIndex = 1;
            // 
            // BtnDisCamR
            // 
            this.BtnDisCamR.Location = new System.Drawing.Point(597, 514);
            this.BtnDisCamR.Name = "BtnDisCamR";
            this.BtnDisCamR.Size = new System.Drawing.Size(96, 23);
            this.BtnDisCamR.TabIndex = 2;
            this.BtnDisCamR.Text = "Disconect";
            this.BtnDisCamR.UseVisualStyleBackColor = true;
            this.BtnDisCamR.Click += new System.EventHandler(this.BtnDisCamR_Click);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.tabPage1);
            this.Setting.Controls.Add(this.tabPage2);
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Setting.Location = new System.Drawing.Point(2, 1);
            this.Setting.Name = "Setting";
            this.Setting.SelectedIndex = 0;
            this.Setting.Size = new System.Drawing.Size(721, 615);
            this.Setting.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtData);
            this.tabPage1.Controls.Add(this.DownRz);
            this.tabPage1.Controls.Add(this.DownZ);
            this.tabPage1.Controls.Add(this.DownY);
            this.tabPage1.Controls.Add(this.DownX);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.UpRz);
            this.tabPage1.Controls.Add(this.UpZ);
            this.tabPage1.Controls.Add(this.UpY);
            this.tabPage1.Controls.Add(this.UpX);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BtnDisRobot);
            this.tabPage1.Controls.Add(this.BtnClear);
            this.tabPage1.Controls.Add(this.BtnMovePos);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.BtnAutoCal);
            this.tabPage1.Controls.Add(this.BtnSendR);
            this.tabPage1.Controls.Add(this.BtnGetCurPos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.BtnMovePosTrigger);
            this.tabPage1.Controls.Add(this.BtnMovePick);
            this.tabPage1.Controls.Add(this.BtnTriggerPick);
            this.tabPage1.Controls.Add(this.BtnTrainTrigger);
            this.tabPage1.Controls.Add(this.BtnTraningPick);
            this.tabPage1.Controls.Add(this.BtnConRobot);
            this.tabPage1.Controls.Add(this.BtnSentCam);
            this.tabPage1.Controls.Add(this.TxtPortRobot);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.TxtF);
            this.tabPage1.Controls.Add(this.BtnDisCamR);
            this.tabPage1.Controls.Add(this.TxtRz);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TxtRy);
            this.tabPage1.Controls.Add(this.BtnDisCam);
            this.tabPage1.Controls.Add(this.TxtRx);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TxtZ);
            this.tabPage1.Controls.Add(this.TxtY);
            this.tabPage1.Controls.Add(this.TxtIpCam);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.TextPartRuntime);
            this.tabPage1.Controls.Add(this.BtnConCam);
            this.tabPage1.Controls.Add(this.TxtPart);
            this.tabPage1.Controls.Add(this.StepRz);
            this.tabPage1.Controls.Add(this.StepZ);
            this.tabPage1.Controls.Add(this.StepY);
            this.tabPage1.Controls.Add(this.StepX);
            this.tabPage1.Controls.Add(this.TxtX);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.TxtPortCamR);
            this.tabPage1.Controls.Add(this.TxtIpRobot);
            this.tabPage1.Controls.Add(this.TxtPortCam);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.TxtCommand);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.BtnConCamR);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtCommandR);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DownRz
            // 
            this.DownRz.Location = new System.Drawing.Point(247, 209);
            this.DownRz.Name = "DownRz";
            this.DownRz.Size = new System.Drawing.Size(33, 23);
            this.DownRz.TabIndex = 2;
            this.DownRz.Text = "-";
            this.DownRz.UseVisualStyleBackColor = true;
            this.DownRz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownRZ_MouseDown);
            // 
            // DownZ
            // 
            this.DownZ.Location = new System.Drawing.Point(247, 179);
            this.DownZ.Name = "DownZ";
            this.DownZ.Size = new System.Drawing.Size(33, 23);
            this.DownZ.TabIndex = 2;
            this.DownZ.Text = "-";
            this.DownZ.UseVisualStyleBackColor = true;
            this.DownZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownZ_MouseDown);
            // 
            // DownY
            // 
            this.DownY.Location = new System.Drawing.Point(247, 150);
            this.DownY.Name = "DownY";
            this.DownY.Size = new System.Drawing.Size(33, 23);
            this.DownY.TabIndex = 2;
            this.DownY.Text = "-";
            this.DownY.UseVisualStyleBackColor = true;
            this.DownY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownY_MouseDown);
            // 
            // DownX
            // 
            this.DownX.Location = new System.Drawing.Point(247, 121);
            this.DownX.Name = "DownX";
            this.DownX.Size = new System.Drawing.Size(33, 23);
            this.DownX.TabIndex = 2;
            this.DownX.Text = "-";
            this.DownX.UseVisualStyleBackColor = true;
            this.DownX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownX_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpRz
            // 
            this.UpRz.Location = new System.Drawing.Point(209, 209);
            this.UpRz.Name = "UpRz";
            this.UpRz.Size = new System.Drawing.Size(33, 23);
            this.UpRz.TabIndex = 2;
            this.UpRz.Text = "+";
            this.UpRz.UseVisualStyleBackColor = true;
            this.UpRz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpRZ_MouseDown);
            // 
            // UpZ
            // 
            this.UpZ.Location = new System.Drawing.Point(208, 179);
            this.UpZ.Name = "UpZ";
            this.UpZ.Size = new System.Drawing.Size(33, 23);
            this.UpZ.TabIndex = 2;
            this.UpZ.Text = "+";
            this.UpZ.UseVisualStyleBackColor = true;
            this.UpZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpZ_MouseDown);
            // 
            // UpY
            // 
            this.UpY.Location = new System.Drawing.Point(208, 150);
            this.UpY.Name = "UpY";
            this.UpY.Size = new System.Drawing.Size(33, 23);
            this.UpY.TabIndex = 2;
            this.UpY.Text = "+";
            this.UpY.UseVisualStyleBackColor = true;
            this.UpY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpY_MouseDown);
            // 
            // UpX
            // 
            this.UpX.Location = new System.Drawing.Point(208, 121);
            this.UpX.Name = "UpX";
            this.UpX.Size = new System.Drawing.Size(33, 23);
            this.UpX.TabIndex = 2;
            this.UpX.Text = "+";
            this.UpX.UseVisualStyleBackColor = true;
            this.UpX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpX_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnMovePosTrigger
            // 
            this.BtnMovePosTrigger.Location = new System.Drawing.Point(86, 494);
            this.BtnMovePosTrigger.Name = "BtnMovePosTrigger";
            this.BtnMovePosTrigger.Size = new System.Drawing.Size(68, 56);
            this.BtnMovePosTrigger.TabIndex = 2;
            this.BtnMovePosTrigger.Text = "Move Pos trigger";
            this.BtnMovePosTrigger.UseVisualStyleBackColor = true;
            this.BtnMovePosTrigger.Click += new System.EventHandler(this.BtnPosTrigger_Click);
            // 
            // BtnMovePick
            // 
            this.BtnMovePick.Location = new System.Drawing.Point(248, 494);
            this.BtnMovePick.Name = "BtnMovePick";
            this.BtnMovePick.Size = new System.Drawing.Size(79, 55);
            this.BtnMovePick.TabIndex = 2;
            this.BtnMovePick.Text = "Move to Pick Place";
            this.BtnMovePick.UseVisualStyleBackColor = true;
            this.BtnMovePick.Click += new System.EventHandler(this.BtnMovePick_Click);
            // 
            // BtnTriggerPick
            // 
            this.BtnTriggerPick.Location = new System.Drawing.Point(163, 494);
            this.BtnTriggerPick.Name = "BtnTriggerPick";
            this.BtnTriggerPick.Size = new System.Drawing.Size(79, 55);
            this.BtnTriggerPick.TabIndex = 2;
            this.BtnTriggerPick.Text = "Trigger";
            this.BtnTriggerPick.UseVisualStyleBackColor = true;
            this.BtnTriggerPick.Click += new System.EventHandler(this.BtnTriggerPick_Click);
            // 
            // BtnTrainTrigger
            // 
            this.BtnTrainTrigger.Location = new System.Drawing.Point(86, 391);
            this.BtnTrainTrigger.Name = "BtnTrainTrigger";
            this.BtnTrainTrigger.Size = new System.Drawing.Size(68, 56);
            this.BtnTrainTrigger.TabIndex = 2;
            this.BtnTrainTrigger.Text = "Trigger Pos";
            this.BtnTrainTrigger.UseVisualStyleBackColor = true;
            this.BtnTrainTrigger.Click += new System.EventHandler(this.BtnTrainTrigger_Click);
            // 
            // BtnTraningPick
            // 
            this.BtnTraningPick.Location = new System.Drawing.Point(163, 392);
            this.BtnTraningPick.Name = "BtnTraningPick";
            this.BtnTraningPick.Size = new System.Drawing.Size(79, 55);
            this.BtnTraningPick.TabIndex = 2;
            this.BtnTraningPick.Text = "Pick Place Pos";
            this.BtnTraningPick.UseVisualStyleBackColor = true;
            this.BtnTraningPick.Click += new System.EventHandler(this.BtnTraningPick_Click);
            // 
            // TextPartRuntime
            // 
            this.TextPartRuntime.Location = new System.Drawing.Point(18, 516);
            this.TextPartRuntime.Multiline = true;
            this.TextPartRuntime.Name = "TextPartRuntime";
            this.TextPartRuntime.Size = new System.Drawing.Size(50, 23);
            this.TextPartRuntime.TabIndex = 1;
            this.TextPartRuntime.Text = "1";
            this.TextPartRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPart
            // 
            this.TxtPart.Location = new System.Drawing.Point(18, 409);
            this.TxtPart.Multiline = true;
            this.TxtPart.Name = "TxtPart";
            this.TxtPart.Size = new System.Drawing.Size(50, 23);
            this.TxtPart.TabIndex = 1;
            this.TxtPart.Text = "1";
            this.TxtPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StepRz
            // 
            this.StepRz.Location = new System.Drawing.Point(137, 209);
            this.StepRz.Multiline = true;
            this.StepRz.Name = "StepRz";
            this.StepRz.Size = new System.Drawing.Size(65, 23);
            this.StepRz.TabIndex = 1;
            this.StepRz.Text = "2";
            this.StepRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StepZ
            // 
            this.StepZ.Location = new System.Drawing.Point(136, 179);
            this.StepZ.Multiline = true;
            this.StepZ.Name = "StepZ";
            this.StepZ.Size = new System.Drawing.Size(65, 23);
            this.StepZ.TabIndex = 1;
            this.StepZ.Text = "3";
            this.StepZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StepY
            // 
            this.StepY.Location = new System.Drawing.Point(136, 150);
            this.StepY.Multiline = true;
            this.StepY.Name = "StepY";
            this.StepY.Size = new System.Drawing.Size(65, 23);
            this.StepY.TabIndex = 1;
            this.StepY.Text = "3";
            this.StepY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StepX
            // 
            this.StepX.Location = new System.Drawing.Point(136, 121);
            this.StepX.Multiline = true;
            this.StepX.Name = "StepX";
            this.StepX.Size = new System.Drawing.Size(65, 23);
            this.StepX.TabIndex = 1;
            this.StepX.Text = "3";
            this.StepX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(29, 498);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "Part";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 391);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Part";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(136, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Step move";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 476);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Runtime Pick and Place";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Camera AS200";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 373);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "Training Pick and Place";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Traning pick place";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 616);
            this.Controls.Add(this.Setting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Setting.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

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
        private Button BtnTrainTrigger;
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