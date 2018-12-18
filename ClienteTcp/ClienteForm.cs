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
            Connect("172.17.20.73");
        }

        void Connect(String server)
        {

            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.

                Int32 port = 5000;
                TcpClient client = new TcpClient(server, port);
                
                client.Close();
            }catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

           
        }

    }
}

