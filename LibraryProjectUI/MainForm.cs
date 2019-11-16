using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void BtnManageStudent_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnManageStudent.Height;
            SidePanel.Top = btnManageStudent.Top;
        }

        private void BtnManageBooks_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnManageBooks.Height;
            SidePanel.Top = btnManageBooks.Top;
        }

        private void BtnManageCards_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnManageCards.Height;
            SidePanel.Top = btnManageCards.Top;
        }

        private void BtnIssueBook_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnIssueBook.Height;
            SidePanel.Top = btnIssueBook.Top;
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReturnBook.Height;
            SidePanel.Top = btnReturnBook.Top;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ManageStudent1_Load(object sender, EventArgs e)
        {

        }
    }
}
    