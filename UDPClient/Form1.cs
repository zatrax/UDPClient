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

      //global vars
      string oldMessage;

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

              panel_Sending.Enabled = true;

                var s = new UdpState { Endpoint = new IPEndPoint(ip, port), Client = connection };
                connection.BeginReceive(MessageReceived, s);   
            }
            else
            {
                buttonConnect.Text = "Connect";
              panel_Sending.Enabled = false;

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
          if (buttonConnect.Text == "Disconnect")
          {
            var client = ((UdpState) (ar.AsyncState)).Client;
            var endpoint = ((UdpState) (ar.AsyncState)).Endpoint;

            var receiveBytes = client.EndReceive(ar, ref endpoint);
            var receiveString = Encoding.ASCII.GetString(receiveBytes) + "\r\n";

            SetText(textBoxConsole, receiveString);

            var ip = IPAddress.Parse(textBoxIpAddress.Text);
            var port = int.Parse(textBoxPort.Text);
            var s = new UdpState {Endpoint = new IPEndPoint(ip, port), Client = connection};
            connection.BeginReceive(MessageReceived, s);
          }
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
          oldMessage = message;

            textBoxMessageToSend.Text = "";

            connection.Send(Encoding.Default.GetBytes(message), message.Count());
        }

        private void textBoxMessageToSend_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
          
            buttonSendMessage_Click(sender, e);
          
          if(e.KeyCode == Keys.Up)
            textBoxMessageToSend.Text = oldMessage;
        }


        private void button_LedOn_Click(object sender, EventArgs e)
        {
          var message = "!Led:ON";
          connection.Send(Encoding.Default.GetBytes(message), message.Count());

        }

        private void button_LedOff_Click(object sender, EventArgs e)
        {
          var message = "!Led:OFF";
          connection.Send(Encoding.Default.GetBytes(message), message.Count());
        }
    }
}
