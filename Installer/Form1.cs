using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Icon = new Icon("logo.ico");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;
        }

        private void userDbServerButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start UserDB Server");
            Process.Start(@".\apps\userDb\server\Database Server.exe");
        }

        private void userDbClientButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start UserDB Client");
            Process.Start(@".\apps\userDb\client\User Database Client.exe");
        }

        private void openAboutBox(object sender,EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Icon = new Icon("logo.ico");
            aboutBox.Name = "About" + Application.ProductName;
            aboutBox.Show();
        }
    }
}