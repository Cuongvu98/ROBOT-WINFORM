using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private TcpClient CameraClient = new TcpClient();
        private TcpClient CameraClientR = new TcpClient();
        private TcpClient RobotClient = new TcpClient();
        String[,] poss = new string[4, 6];
        double fig;

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

        static void DisconnectServer(TcpClient? client)
        {
            if (client != null && client.Connected)
            {
                client.Close();
                client = null;
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
            Stream.ReadTimeout = 10000;
            int bytesReadCam = await Stream.ReadAsync(buffer, 0, buffer.Length);
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
            Stream.ReadTimeout = 10000;
            int bytesReadCam = await Stream.ReadAsync(buffer, 0, buffer.Length);
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

        private async Task<string> ActivateRobot(string Position, double fig)
        {
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
            await SendCommand(CameraClient, command, "Camera");
            await ReceiveData(CameraClient, "Camera", buffer);
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
            await SendCommand(CameraClient, command, "Camera");
            string receivedDataCam = await ReceiveData(CameraClient, "Camera", buffer);
            if (receivedDataCam.Contains("ACB,2"))
            {
                string NextPosition = receivedDataCam.Substring(6);
                string result1 = await ActivateRobot(NextPosition, fig);
                Console.WriteLine("robot responsive ==>" + result1);
                if (result1 != "")
                {
                    string commandNextPosition = "AC,1,1," + result1;
                    await SendCommand(CameraClient, commandNextPosition, "Camera");
                    string CamResponse = await ReceiveData(CameraClient, "Camera", buffer);
                    Console.WriteLine("Cam phan hoi==>" + CamResponse);
                    while (CamResponse.Contains("AC,2"))
                    {
                        NextPosition = CamResponse.Substring(5);
                        string result2 = await ActivateRobot(NextPosition, fig);

                        if (result2 != "")
                        {
                            string commandNextPosition2 = "AC,1,1," + result2;
                            await SendCommand(CameraClient, commandNextPosition2, "Camera");
                            CamResponse = await ReceiveData(CameraClient, "Camera", buffer);
                            Console.WriteLine(CamResponse);
                            await Task.Delay(500);

                        }
                    }

                    if (CamResponse.Contains("AC,1"))
                    {
                        MessageBox.Show("Calib Done");
                    }
                    else MessageBox.Show("Calib fail");
                }
            }
            BtnAutoCal.Enabled = true;
            BtnGetCurPos.Enabled = true;
        }

        private async void BtnMovePos_Click(object sender, EventArgs e)
        {
            BtnMovePos.Enabled = false;
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
            BtnMovePos.Enabled = true;
        }

        private async void BtnConCamR_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            ConnectServer(TxtIpRobot.Text, "23", "Camera", ref CameraClientR);
            await ReceiveData(CameraClientR, "CameraR", buffer);
            BtnConCamR.Enabled = false;
            BtnDisCamR.Enabled = true;
        }

        private void BtnDisCamR_Click(object sender, EventArgs e)
        {
            DisconnectServer(CameraClientR);
            BtnConCamR.Enabled = true;
            BtnDisCamR.Enabled = false;
        }

        private async void BtnSendR_Click(object sender, EventArgs e)
        {
            BtnSendR.Enabled = false;
            byte[] buffer = new byte[1024];
            string command = TxtCommandR.Text.Trim();
            await SendCommand(CameraClientR, command, "CameraR");
            await ReceiveData(CameraClientR, "CameraR", buffer);
            BtnSendR.Enabled = true;
        }

        private async void UpX_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{Convert.ToDouble(p[0]) + Convert.ToDouble(StepX)},{p[1]},{p[2]},{p[3]},{p[4]},{p[5]}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void DownX_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{Convert.ToDouble(p[0]) - Convert.ToDouble(StepX)},{p[1]},{p[2]},{p[3]},{p[4]},{p[5]}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void UpY_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{p[0]},{Convert.ToDouble(p[1]) + Convert.ToDouble(StepY)},{p[2]},{p[3]},{p[4]},{p[5]}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void DownY_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{p[0]},{Convert.ToDouble(p[1]) - Convert.ToDouble(StepY)},{p[2]},{p[3]},{p[4]},{p[5]}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void UpZ_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{p[0]},{p[1]},{Convert.ToDouble(p[2]) + Convert.ToDouble(StepZ)},{p[3]},{p[4]},{p[5]}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void DownZ_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{p[0]},{p[1]},{Convert.ToDouble(p[2]) - Convert.ToDouble(StepZ)},{p[3]},{p[4]},{p[5]}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void UpRZ_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{p[0]},{p[1]},{p[2]},{p[3]},{p[4]},{Convert.ToDouble(p[5]) + Convert.ToDouble(StepRz)}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void DownRZ_MouseDown(object sender, MouseEventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            await ActivateRobot($"{p[0]},{p[1]},{p[2]},{p[3]},{p[4]},{Convert.ToDouble(p[5]) - Convert.ToDouble(StepRz)}", Convert.ToDouble(p[6]));
            string receivedDataRobot1 = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p1 = receivedDataRobot1.Split(' ');
            TxtX.Text = p1[0];
            TxtY.Text = p1[1];
            TxtZ.Text = p1[2];
            TxtRx.Text = p1[3];
            TxtRy.Text = p1[4];
            TxtRz.Text = p1[5];
            TxtF.Text = p1[6];
        }

        private async void BtnTrainTrigger_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            string receivedDataCamera = await SendReceiveData(CameraClient, $"TT,{TxtPart},{p[0]},{p[1]},{p[2]},{p[5]},{p[4]},{p[3]}", "Camera", buffer);
            if (receivedDataCamera.Contains("TT,1"))
            {
                MessageBox.Show("Training trigger part Pos {TxtPart} successfully");
                poss[Convert.ToInt16(TxtPart) - 1, 0] = "1";
                poss[Convert.ToInt16(TxtPart) - 1, 1] = string.Join(",", p);
            }
            else
            {
                MessageBox.Show("Training fail");
                poss[Convert.ToInt16(TxtPart) - 1, 0] = "0";
            }
        }

        private async void BtnTraningPick_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
            string[] p = receivedDataRobot.Split(' ');
            fig = Convert.ToDouble(p[6]);
            string receivedDataCamera = await SendReceiveData(CameraClient, $"TTR,{TxtPart},{p[0]},{p[1]},{p[2]},{p[5]},{p[4]},{p[3]}", "Camera", buffer);
            if (receivedDataCamera.Contains("TTR,1"))
            {
                MessageBox.Show("Training pick, place part Pos {TxtPart} successfully");
                poss[Convert.ToInt16(TxtPart) - 1, 2] = "1";
                poss[Convert.ToInt16(TxtPart) - 1, 3] = string.Join(",", p);
            }
            else
            {
                MessageBox.Show("Training fail");
                poss[Convert.ToInt16(TxtPart) - 1, 2] = "0";
            }
        }

        private async void BtnTriggerPick_Click(object sender, EventArgs e)
        {
            if (poss[Convert.ToInt16(TextPartRuntime) - 1, 2] == "1")
            {
                byte[] buffer = new byte[1024];
                string receivedDataRobot = await SendReceiveData(RobotClient, "0,0,0,0,0,0,1,", "Robot", buffer);
                string[] p = receivedDataRobot.Split(' ');
                string receivedDataCamera = await SendReceiveData(CameraClient, $"XT,{TxtPart},1,{p[0]},{p[1]},{p[2]},{p[5]},{p[4]},{p[3]}", "Camera", buffer);
                if (receivedDataCamera.Contains("XT,1"))
                {
                    MessageBox.Show("OK");
                    poss[Convert.ToInt16(TxtPart) - 1, 4] = "1";
                    string NextPosition = receivedDataCamera.Substring(5);
                    poss[Convert.ToInt16(TxtPart) - 1, 5] = NextPosition; //Dang Rx, Rz lech nhau
                }
                else
                {
                    MessageBox.Show("Not find Pos Pick and Place");
                    poss[Convert.ToInt16(TxtPart) - 1, 4] = "0";
                }
            }
            else
            {
                MessageBox.Show("Pos trigger not training");
            }
        }

        private async void BtnMovePick_Click(object sender, EventArgs e)
        {

            if (poss[Convert.ToInt16(TextPartRuntime) - 1, 4] == "1")
            {
                byte[] buffer = new byte[1024];
                await ActivateRobot(poss[Convert.ToInt16(TxtPart) - 1, 5],fig);
            }
            else
            {
                MessageBox.Show("Haven't done find pick, place Pos");
            }
        }
    }
}