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

namespace whichIsMyIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getMyIP();
        }

        private void getMyIP()
        {
            IPHostEntry hostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ip = hostInfo.AddressList[0];
            MessageBox.Show("My IP is " + ip);
        }
    }
}
