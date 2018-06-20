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
            ///this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Icon = new Icon("logo.ico");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void TabButton1_Click(object sender, EventArgs e)
        { tabControl.SelectedTab = tabPage1; }
        private void TabButton2_Click(object sender, EventArgs e)
        { tabControl.SelectedTab = tabPage2; }

        private void openAboutBox(object sender,EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Icon = new Icon("logo.ico");
            aboutBox.Name = "About" + Application.ProductName;
            aboutBox.Show();
        }
    }
}