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
                IPAddress localAddr = IPAddress.Parse("172.17.20.73");
                Listener = new TcpListener(localAddr, port);
                Listener.Start();
                Byte[] bytes = new Byte[1024];
                String data = null;
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
                        // Buffer for reading data
                        Byte[] bytes = new Byte[256];
                        String data = null;

                        // Enter the listening loop.
                        


                            data = null;

                            // Get a stream object for reading and writing
                            NetworkStream stream = client.GetStream();

                            int i;

                            // Loop to receive all the data sent by the client.
                            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                            {
                                // Translate data bytes to a ASCII string.
                                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                                if (textrecibe.InvokeRequired)
                                {
                                    textrecibe.Invoke((MethodInvoker)delegate { textrecibe.Text = data; });
                                }
                                else
                                {
                                    textrecibe.Text = data;
                                }


                                // Process the data sent by the client.
                                data = "Por la alianza!!";

                                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                                // Send back a response.
                                stream.Write(msg, 0, msg.Length);
                                if (textmanda.InvokeRequired)
                                {
                                    textmanda.Invoke((MethodInvoker)delegate { textmanda.Text = data; });
                                }
                                else
                                {
                                    textmanda.Text = data;
                                }
                            }

                            // Shutdown and end connection

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



