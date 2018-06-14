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
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versionNumberLabel.Text = Properties.Settings.Default.version;
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
    }
}
