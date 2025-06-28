using DVLD_My_Version__PresentationLayer;
using DVLD_My_Version__PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_My_Version__PresentationLayer
{
    public partial class frMainPage : Form
    {
        public frMainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frManagePeople managePeople = new frManagePeople();
            managePeople.ShowDialog();
        }

        private void frMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUser users = new frmManageUser();
            users.ShowDialog();
        }
    }
}
