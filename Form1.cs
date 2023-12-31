﻿using System;
using System.Net.Sockets;
using System.Text;

namespace ROBOT_WINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private TcpClient CameraClient = new TcpClient();
        private TcpClient CameraClientR = new TcpClient();
        private TcpClient RobotClient = new TcpClient();
        String[,] poss = new string[4, 6];
        double fig;
        bool Decreasing;

        static void ConnectServer(string Ip, string Port, string NameDevice, ref TcpClient client)
        {
            int P = int.Parse(Port);
            try
            {
                client = new TcpClient();
                client.Connect(Ip, P);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến {NameDevice}. Lỗi: {ex.Message}");
            }
            Console.WriteLine(client.Connected);
        }

        static void DisconnectServer(TcpClient client)
        {
            if (client != null && client.Connected)
            {
                client.Close();
                //client = null;
            }
        }

        private async Task SendCommand(TcpClient client, String command, string NameDevice)
        {
            string commandWithNewLine = command + "\r\n";
            byte[] data1 = Encoding.ASCII.GetBytes(commandWithNewLine);
            TxtData.Invoke((MethodInvoker)(() =>
            {
                TxtData.AppendText($">>>>{NameDevice}: {commandWithNewLine}{Environment.NewLine}");
            }));

            NetworkStream Stream = client.GetStream();
            await Stream.WriteAsync(data1, 0, data1.Length);
        }

        private async Task<string> ReceiveData(TcpClient client, string NameDevice, byte[] buffer)
        {
            StringBuilder Data1 = new StringBuilder();
            NetworkStream Stream = client.GetStream();
            int bytesReadCam = await Stream.ReadAsync(buffer);
            if (bytesReadCam > 0)
            {
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesReadCam);
                Data1.Append(receivedData);
                TxtData.Invoke((MethodInvoker)(() =>
                {
                    TxtData.AppendText($"<<<<{NameDevice}: {receivedData}{Environment.NewLine}");
                }));

                return receivedData;
            }
            return string.Empty;
        }

        private async Task<string> SendReceiveData(TcpClient client, String command, string NameDevice, byte[] buffer)
        {
            string commandWithNewLine = command + "\r\n";
            byte[] data1 = Encoding.ASCII.GetBytes(commandWithNewLine);
            TxtData.Invoke((MethodInvoker)(() =>
            {
                TxtData.AppendText($">>>>{NameDevice}: {commandWithNewLine}{Environment.NewLine}");
            }));
            NetworkStream Stream = client.GetStream();
            await Stream.WriteAsync(data1, 0, data1.Length);
            StringBuilder Data1 = new StringBuilder();
            int bytesRead = await Stream.ReadAsync(buffer, 0, buffer.Length);
            if (bytesRead > 0)
            {
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Data1.Append(receivedData);
                TxtData.Invoke((MethodInvoker)(() =>
                {
                    TxtData.AppendText($"<<<<{NameDevice}: {receivedData}{Environment.NewLine}");
                }));

                return receivedData;
            }
            return string.Empty;
        }

        private async Task<string> ActivateRobot(string Position, double fig)
        {
            Console.WriteLine(Position);
            Position = Position.Replace("\r\n", "");
            string[] parts1 = Position.Split(',');
            String _SendPosToRobot1 = "";
            if (parts1.Length >= 6)
            {
                String temp1 = parts1[3];
                parts1[3] = parts1[5];
                parts1[5] = temp1;
                _SendPosToRobot1 = string.Join(",", parts1);
            }
            String SendPosToRobot1 = $"{_SendPosToRobot1},{fig},";
            await SendCommand(RobotClient, SendPosToRobot1, "Robot");
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await ReceiveData(RobotClient, "Robot", buffer);
            receivedDataRobot = receivedDataRobot.Replace("\r\n", "");
            int LastIndex = receivedDataRobot.LastIndexOf(' ');
            receivedDataRobot = receivedDataRobot.Substring(0, LastIndex);
            string[] parts2 = receivedDataRobot.Split(' ');
            String _RobotSend = "";
            if (parts2.Length >= 6)
            {
                String temp2 = parts2[3];
                parts2[3] = parts2[5];
                parts2[5] = temp2;
                _RobotSend = string.Join(",", parts2);
                Console.WriteLine($"Robot responsive ==> {_RobotSend}");
            }
            return _RobotSend;
        }

        private void BtnConRobot_Click(object sender, EventArgs e)
        {
            ConnectServer(TxtIpRobot.Text, TxtPortRobot.Text, "Robot", ref RobotClient);
            BtnConRobot.Enabled = false;
            BtnDisRobot.Enabled = true;
        }

        private void BtnConCam_Click(object sender, EventArgs e)
        {
            ConnectServer(TxtIpCam.Text, TxtPortCam.Text, "Camera", ref CameraClient);
            BtnConCam.Enabled = false;
            BtnDisCam.Enabled = true;
        }

        private void BtnDisRobot_Click(object sender, EventArgs e)
        {
            DisconnectServer(RobotClient);
            BtnConRobot.Enabled = true;
            BtnDisRobot.Enabled = false;
        }

        private void BtnDisCam_Click(object sender, EventArgs e)
        {
            DisconnectServer(CameraClient);
            BtnConCam.Enabled = true;
            BtnDisCam.Enabled = false;
        }

        private async void BtnSentCam_Click(object sender, EventArgs e)
        {
            BtnSentCam.Enabled = false;
            byte[] buffer = new byte[1024];
            string command = TxtCommand.Text.Trim();
            await SendReceiveData(CameraClient, command, "Camera", buffer);
            BtnSentCam.Enabled = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtData.Clear();
        }

        private async void BtnGetCurPos_Click(object sender, EventArgs e)
        {
            if (RobotClient != null && RobotClient.Connected)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
                    string[] p = receivedDataRobot.Split(' ');
                    if (p.Length >= 6)
                    {
                        TxtX.Text = p[0];
                        TxtY.Text = p[1];
                        TxtZ.Text = p[2];
                        TxtRx.Text = p[3];
                        TxtRy.Text = p[4];
                        TxtRz.Text = p[5];
                        TxtF.Text = p[6];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể gửi lệnh đến Robot. Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kết nối robot trước khi gửi lệnh!");
            }
        }

        private async void BtnAutoCal_Click(object sender, EventArgs e)
        {
            BtnAutoCal.Enabled = false;
            BtnGetCurPos.Enabled = false;
            if (
            !double.TryParse(TxtX.Text, out double X) ||
            !double.TryParse(TxtY.Text, out double Y) ||
            !double.TryParse(TxtZ.Text, out double Z) ||
            !double.TryParse(TxtRx.Text, out double Rx) ||
            !double.TryParse(TxtRy.Text, out double Ry) ||
            !double.TryParse(TxtRz.Text, out double Rz) ||
            !double.TryParse(TxtF.Text, out double fig))
            {
                MessageBox.Show("Nhập số cho các giá trị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string command = $"ACB,1,1,{X},{Y},{Z},{Rz},{Ry},{Rx}";
            byte[] buffer = new byte[1024];
            /*         await SendCommand(CameraClient, command, "Camera");
                     string receivedDataCam = await ReceiveData(CameraClient, "Camera", buffer);*/
            string receivedDataCam = await SendReceiveData(CameraClient, command ,"Camera", buffer);

            if (receivedDataCam.Contains("ACB,2"))
            {
                string NextPosition = receivedDataCam.Substring(6);
                string result1 = await ActivateRobot(NextPosition, fig);
                await Task.Delay(500);
                //Console.WriteLine("robot responsive ==>" + result1);
                if (result1 != "")
                {
                    string commandNextPosition = "AC,1,1," + result1;
                    //await SendCommand(CameraClient, commandNextPosition, "Camera");
                    string CamResponse = await SendReceiveData(CameraClient, commandNextPosition, "Camera", buffer);
                    //Console.WriteLine("Cam phan hoi==>" + CamResponse);
                    while (CamResponse.Contains("AC,2"))
                    {
                        NextPosition = CamResponse.Substring(5);
                        string result2 = await ActivateRobot(NextPosition, fig);
                        await Task.Delay(500);
                        if (result2 != "")
                        {
                            string commandNextPosition2 = "AC,1,1," + result2;
                            //await SendCommand(CameraClient, commandNextPosition2, "Camera");
                            CamResponse = await SendReceiveData(CameraClient, commandNextPosition2, "Camera", buffer);
                            //Console.WriteLine(CamResponse);
                        }
                    }
                    if (CamResponse.Contains("AC,1"))
                    {
                        MessageBox.Show("Calib Done");
                    }
                    else MessageBox.Show("Calib fail");
                }
            }
            else MessageBox.Show("Calib fail");
            BtnAutoCal.Enabled = true;
            BtnGetCurPos.Enabled = true;
        }

        private async void BtnMovePos_Click(object sender, EventArgs e)
        {
            //BtnMovePos.Enabled = false;
            if (
            !double.TryParse(TxtX.Text, out double X) ||
            !double.TryParse(TxtY.Text, out double Y) ||
            !double.TryParse(TxtZ.Text, out double Z) ||
            !double.TryParse(TxtRx.Text, out double Rx) ||
            !double.TryParse(TxtRy.Text, out double Ry) ||
            !double.TryParse(TxtRz.Text, out double Rz) ||
            !double.TryParse(TxtF.Text, out double fig))
            {
                MessageBox.Show("Nhập số cho các giá trị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result1 = await ActivateRobot($"{X},{Y},{Z},{Rz},{Ry},{Rx}", fig);
            if (result1 == "")
            {
                MessageBox.Show("Lỗi robot di chuyển");
            }
            //BtnMovePos.Enabled = true;
        }

        private async void BtnConCamR_Click(object sender, EventArgs e)
        {
            BtnConCamR.Enabled = false;
            byte[] buffer = new byte[1024];
            ConnectServer(TxtIpRobot.Text, "23", "Camera", ref CameraClientR);
            await ReceiveData(CameraClientR, "CameraR", buffer);
            BtnDisCamR.Enabled = true;
        }

        private void BtnDisCamR_Click(object sender, EventArgs e)
        {
            BtnDisCamR.Enabled = false;
            DisconnectServer(CameraClientR);
            BtnConCamR.Enabled = true;
        }

        private async void BtnSendR_Click(object sender, EventArgs e)
        {
            BtnSendR.Enabled = false;
            byte[] buffer = new byte[1024];
            string command = TxtCommandR.Text.Trim();
            await SendReceiveData(CameraClient, command, "CameraR", buffer);
            BtnSendR.Enabled = true;
        }

        private async void UpX_MouseDown(object sender, MouseEventArgs e)
        {
            double X = 200;
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "1,0,0,0,0,0,1,", "Robot", buffer);
            if (receivedDataRobot == "OK")
            {
            await SendCommand(RobotClient, "{X},{TxtY.Text},{TxtZ.Text},{TxtRx.Text},{TxtRy.Text},{TxtRz.Text},{TxtF.Text},,", "Robot");
            }
            else
                MessageBox.Show("Lỗi robot di chuyển");
        }

        private async void UpX_MouseUp(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            if (p.Length >= 6)
            {
                TxtX.Text = p[0];
                TxtY.Text = p[1];
                TxtZ.Text = p[2];
                TxtRx.Text = p[3];
                TxtRy.Text = p[4];
                TxtRz.Text = p[5];
                TxtF.Text = p[6];
            }
        }

        private async void DownX_MouseDown(object sender, MouseEventArgs e)
        {
            double X = 100;
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "1,0,0,0,0,0,1,", "Robot", buffer);
            if (receivedDataRobot == "OK")
            {
                await SendCommand(RobotClient, "{X},{TxtY.Text},{TxtZ.Text},{TxtRx.Text},{TxtRy.Text},{TxtRz.Text},{TxtF.Text},,", "Robot");
            }
            else
                MessageBox.Show("Lỗi robot di chuyển");
        }

        private async void DownX_MouseUp(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            if (p.Length >= 6)
            {
                TxtX.Text = p[0];
                TxtY.Text = p[1];
                TxtZ.Text = p[2];
                TxtRx.Text = p[3];
                TxtRy.Text = p[4];
                TxtRz.Text = p[5];
                TxtF.Text = p[6];
            }
        }

        private async void UpY_MouseDown(object sender, MouseEventArgs e)
        {
            Decreasing = true;
            double.TryParse(TxtY.Text, out double k);
            double.TryParse(StepY.Text, out double h);
            while (Decreasing)
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, $"{TxtX.Text},{k},{TxtZ.Text},{TxtRx.Text},{TxtRy.Text},{TxtRz.Text},{TxtF.Text},", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                TxtY.Text = p[1];
                k = k + h;
            }
        }

        private void UpY_MouseUp(object sender, MouseEventArgs e)
        {
            Decreasing = false;
        }

        private async void DownY_MouseDown(object sender, MouseEventArgs e)
        {
            Decreasing = true;
            double.TryParse(TxtY.Text, out double k);
            double.TryParse(StepY.Text, out double h);
            while (Decreasing)
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, $"{TxtX.Text},{k},{TxtZ.Text},{TxtRx.Text},{TxtRy.Text},{TxtRz.Text},{TxtF.Text},", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                TxtY.Text = p[1];
                k = k - h;
            }
        }

        private void DownY_MouseUp(object sender, MouseEventArgs e)
        {
            Decreasing = false;
        }

        private async void UpZ_MouseDown(object sender, MouseEventArgs e)
        {
            Decreasing = true;
            double.TryParse(TxtZ.Text, out double k);
            double.TryParse(StepZ.Text, out double h);
            while (Decreasing)
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, $"{TxtX.Text},{TxtY.Text},{k},{TxtRx.Text},{TxtRy.Text},{TxtRz.Text},{TxtF.Text},", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                TxtZ.Text = p[2];
                k = k + h;
            }
        }

        private void UpZ_MouseUp(object sender, MouseEventArgs e)
        {
            Decreasing = false;
        }

        private async void DownZ_MouseDown(object sender, MouseEventArgs e)
        {
            Decreasing = true;
            double.TryParse(TxtZ.Text, out double k);
            double.TryParse(StepZ.Text, out double h);
            while (Decreasing)
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, $"{TxtX.Text},{TxtY.Text},{k},{TxtRx.Text},{TxtRy.Text},{TxtRz.Text},{TxtF.Text},", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                TxtZ.Text = p[2];
                k = k - h;
            }
        }

        private void DownZ_MouseUp(object sender, MouseEventArgs e)
        {
            Decreasing = false;
        }

        private async void UpRZ_MouseDown(object sender, MouseEventArgs e)
        {
            Decreasing = true;
            double.TryParse(TxtRz.Text, out double k);
            double.TryParse(StepRz.Text, out double h);
            while (Decreasing)
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, $"{TxtX.Text},{TxtY.Text},{TxtZ.Text},{TxtRx.Text},{TxtRy.Text},{k},{TxtF.Text},", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                TxtRz.Text = p[5];
                k = k + h;
            }
        }

        private void UpRz_MouseUp(object sender, MouseEventArgs e)
        {
            Decreasing = false;
        }

        private async void DownRz_MouseDown(object sender, MouseEventArgs e)
        {
            Decreasing = true;
            double.TryParse(TxtRz.Text, out double k);
            double.TryParse(StepRz.Text, out double h);
            while (Decreasing)
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, $"{TxtX.Text},{TxtY.Text},{TxtZ.Text},{TxtRx.Text},{TxtRy.Text},{k},{TxtF.Text},", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                TxtRz.Text = p[5];
                k = k - h;
            }
        }

        private void DownRz_MouseUp(object sender, MouseEventArgs e)
        {
            Decreasing = false;
        }

        private async void BtnTrainPosTrigger_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            string receivedDataCamera = await SendReceiveData(CameraClient, $"TT,{TxtPart.Text},{p[0]},{p[1]},{p[2]},{p[5]},{p[4]},{p[3]}", "Camera", buffer);
            if (receivedDataCamera.Contains("TT,1"))
            {
                MessageBox.Show($"Training trigger part Pos {TxtPart.Text} successfully");
                poss[Convert.ToInt16(TxtPart.Text) - 1, 0] = "1";
                poss[Convert.ToInt16(TxtPart.Text) - 1, 1] = string.Join(",", p);
            }
            else
            {
                MessageBox.Show("Training fail");
                poss[Convert.ToInt16(TxtPart.Text) - 1, 0] = "0";
            }
        }

        private async void BtnTraningPick_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            fig = Convert.ToDouble(p[6]);
            string receivedDataCamera = await SendReceiveData(CameraClient, $"TTR,{TxtPart.Text},{p[0]},{p[1]},{p[2]},{p[5]},{p[4]},{p[3]}", "Camera", buffer);
            if (receivedDataCamera.Contains("TTR,1"))
            {
                MessageBox.Show($"Training pick, place part Pos {TxtPart.Text} successfully");
                poss[Convert.ToInt16(TxtPart.Text) - 1, 2] = "1";
                poss[Convert.ToInt16(TxtPart.Text) - 1, 3] = string.Join(",", p);
            }
            else
            {
                MessageBox.Show("Training fail");
                poss[Convert.ToInt16(TxtPart.Text) - 1, 2] = "0";
            }
        }

        private async void BtnTriggerPick_Click(object sender, EventArgs e)
        {
            if (poss[Convert.ToInt16(TextPartRuntime.Text) - 1, 2] == "1")
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                string receivedDataCamera = await SendReceiveData(CameraClient, $"XT,{TxtPart.Text},1,{p[0]},{p[1]},{p[2]},{p[5]},{p[4]},{p[3]}", "Camera", buffer);
                if (receivedDataCamera.Contains("XT,1"))
                {
                    MessageBox.Show("OK");
                    poss[Convert.ToInt16(TxtPart.Text) - 1, 4] = "1";
                    string NextPosition = receivedDataCamera.Substring(5);
                    poss[Convert.ToInt16(TxtPart.Text) - 1, 5] = NextPosition; //Dang Rx, Rz lech nhau
                }
                else
                {
                    MessageBox.Show("Not find Pos Pick and Place");
                    poss[Convert.ToInt16(TxtPart.Text) - 1, 4] = "0";
                }
            }
            else
            {
                MessageBox.Show("Pos not training");
            }
        }

        private async void BtnMovePick_Click(object sender, EventArgs e)
        {

            if (poss[Convert.ToInt16(TextPartRuntime.Text) - 1, 4] == "1")
            {

                await ActivateRobot(poss[Convert.ToInt16(TxtPart.Text) - 1, 5], fig);
            }
            else
            {
                MessageBox.Show("Haven't done find pick, place Pos");
            }
        }

        private async void BtnMovePosTrigger_Click(object sender, EventArgs e)
        {
            if (poss[Convert.ToInt16(TextPartRuntime.Text) - 1, 0] == "1")
            {
                byte[] buffer = new byte[1024];
                await SendReceiveData(RobotClient, $"{poss[Convert.ToInt16(TxtPart.Text) - 1, 1]},", "Robot", buffer);

            }
            else
            {
                MessageBox.Show("Pos trigger not training");
            }
        }

        private void TxtPortRobot_TextChanged(object sender, EventArgs e)
        {

        }

    }
}