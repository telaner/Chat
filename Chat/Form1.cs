using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chat
{
    public partial class Form1 : Form
    {
        private Socket sck = null;
        private EndPoint epLocal = null;
        private EndPoint epRemote = null;
        private byte[] buffer;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }

        private static string GetLocalIP() 
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList) 
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) 
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), int.Parse(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), int.Parse(textFriendsPort.Text));
                sck.Connect(epRemote);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                buttonSend.Enabled = true;
                buttonStart.Text =  "Connected";
                buttonStart.Enabled = false;
                textMessage.Focus();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallBack(IAsyncResult aResult) 
        {
            try 
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if(size > 0) 
                {
                    byte[] receivedData = new byte[1500];
                    
                    receivedData =(byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    listMessage.Items.Add("Friend: " + receivedMessage);
                    listMessage.SelectedIndex = listMessage.Items.Count - 1;
                    listMessage.SelectedIndex = -1;
                }

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception exp) 
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try 
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                sck.Send(msg);

                listMessage.Items.Add("You: " + textMessage.Text);
                listMessage.SelectedIndex=listMessage.Items.Count -1;
                listMessage.SelectedIndex = -1;

                textMessage.Clear();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
