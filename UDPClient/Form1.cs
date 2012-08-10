using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        private UdpClient connection;

        public Form1()
        {
            InitializeComponent();

            connection = new UdpClient();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
            {
                buttonConnect.Text = "Disconnect";

                var ip = IPAddress.Parse(textBoxIpAddress.Text);
                var port = int.Parse(textBoxPort.Text);
                connection.Connect(ip, port);

                textBoxMessageToSend.Enabled = true;
                buttonSendMessage.Enabled = true;

                var s = new UdpState { Endpoint = new IPEndPoint(ip, port), Client = connection };
                connection.BeginReceive(MessageReceived, s);   
            }
            else
            {
                buttonConnect.Text = "Connect";
                textBoxMessageToSend.Enabled = false;
                buttonSendMessage.Enabled = false;

                connection.Close();
            }
        }

        private class UdpState
        {
            public IPEndPoint Endpoint { get; set; }
            public UdpClient Client { get; set; }
        }

        private void MessageReceived(IAsyncResult ar)
        {
            var client = ((UdpState)(ar.AsyncState)).Client;
            var endpoint = ((UdpState)(ar.AsyncState)).Endpoint;

            var receiveBytes = client.EndReceive(ar, ref endpoint);
            var receiveString = Encoding.ASCII.GetString(receiveBytes) + "\r\n";

            SetText(textBoxConsole, receiveString);

            var ip = IPAddress.Parse(textBoxIpAddress.Text);
            var port = int.Parse(textBoxPort.Text);
            var s = new UdpState { Endpoint = new IPEndPoint(ip, port), Client = connection };
            connection.BeginReceive(MessageReceived, s);
        }

        delegate void SetTextCallback(Control ctrl, string text);

        private void SetText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new SetTextCallback(SetText), ctrl, text);
            }
            else
            {
                ctrl.Text += text;
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            var message = textBoxMessageToSend.Text;
            textBoxMessageToSend.Text = "";

            connection.Send(Encoding.Default.GetBytes(message), message.Count());
        }
    }
}
