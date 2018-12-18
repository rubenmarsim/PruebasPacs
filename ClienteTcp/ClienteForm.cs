using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace ClienteTcp
{
    public partial class ClienteForm : Form
    {

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
        }

        void Connect(String server,string message)
        {

            try
            {
                Int32 port = 5000;
                TcpClient client = new TcpClient(server, port);
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);




                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                if (textmanda.InvokeRequired)
                {
                    textmanda.Invoke((MethodInvoker)delegate { textmanda.Text = sendBox.Text; });
                }
                else
                {
                    textmanda.Text = sendBox.Text;
                }
                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[1024];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                if (textrecibe.InvokeRequired)
                {
                    textrecibe.Invoke((MethodInvoker)delegate { textrecibe.Text = responseData; });
                }
                else
                {
                    textrecibe.Text = responseData;
                }
                // Close everything.
                stream.Close();
                client.Close();
            }catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }



           
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (sendBox.Text != string.Empty)
            {
                Connect("172.17.20.73",sendBox.Text);
            }
            else {
                MessageBox.Show("tiendes que escribir algo en el textbox");
            }
           
        }
    }
}

