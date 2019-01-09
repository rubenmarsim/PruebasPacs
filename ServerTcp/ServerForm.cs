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

namespace ServerTcp
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            ServerLabel.Text = "Server is Running...";
            Thread serverThread = new Thread(ServerOn);
            serverThread.SetApartmentState(ApartmentState.STA);
            serverThread.Start();
        }

        private void ServerOn()
        {

            TcpListener Listener = null;
            try
            {
                Int32 port = 5000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                Listener = new TcpListener(localAddr, port);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            while (true)
            {
                TcpClient client = null;
                try
                {

                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();

                        if (statusLabel.InvokeRequired)
                        {
                            statusLabel.Invoke((MethodInvoker)delegate { statusLabel.Text = "Connected client\n"; });
                        }
                        else
                        {
                            statusLabel.Text = "Connected client\n";
                        }

                        client.Close();
                    }
                }catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }


            }
        }
        
    }
}



