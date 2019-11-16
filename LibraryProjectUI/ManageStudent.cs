using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace LibraryProjectUI
{
    public partial class ManageStudent : UserControl
    {
        public ManageStudent()
        {
            InitializeComponent();
        }
        //create a database object
        ProjectPracticeEntities _db = new ProjectPracticeEntities();
        //default path for image
        string defaultPath = "";
        string browsepath = "";
        private void DefaultDisplay()
        {
            txtFullname.Text = "";
            rbdMale.Checked = false;
            rbdFemale.Checked = false;
            txtPhoneNo.Text = "";
            txtRollNo.Text = "";
            txtEmail.Text = "";
            defaultPath = Application.StartupPath + "\\94837_file_256x256.png";
            pictureBox1.ImageLocation = defaultPath;
        }
        
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            defaultPath = Application.StartupPath + "\\94837_file_256x256.png";
            pictureBox1.ImageLocation = defaultPath;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        MemoryStream ms;
        byte[] photo_aray;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            tblStudent tbs = new tblStudent();
            tbs.Fullname = txtFullname.Text;
            tbs.Gender = rbdMale.Checked ? "Male" : "Female";
            tbs.RollNo = txtRollNo.Text;
            tbs.PhoneNo = txtPhoneNo.Text;
            tbs.Email = txtEmail.Text;
            //image conversion from jpg to byte
            ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);
            tbs.Photo = photo_aray;
            //save the tbs to tblStudent
            _db.tblStudents.Add(tbs);
            int i = _db.SaveChanges();
            if (i != 1)
            {
                MessageBox.Show("Student not created");

            }
            else
            {
                MessageBox.Show("Student created");
              
                DefaultDisplay();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Images *.jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                browsepath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = browsepath;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            StudentGridView sdgv = new StudentGridView();
            sdgv.Search(txtSearch.Text);
            if (sdgv.ShowDialog()==DialogResult.OK)
            {
               
               //
            }
            
           
          
        }
    }
}
