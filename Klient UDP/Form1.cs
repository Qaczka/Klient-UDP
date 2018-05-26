using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Klient_UDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void info_feed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = adress.Text;
            int port = Convert.ToUInt16(port.Value);

            try
            {
                UdpClient klient = new UdpClient(host, port);
                Byte[] dane = Encoding.ASCII.GetBytes(chat.Text);
                klient.Send(dane, dane.Length);
                info_feed.ControlAdded("Wyslanie wiadomosci do hosta " + host + ": " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_feed.ControlAdded("Blad nie wyslano wiadomosci");
                MessageBox.Show(ex.ToString(), "Bład");
            }

        }

        private void chat_TextChanged(object sender, EventArgs e)
        {

        }

        private void port_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
