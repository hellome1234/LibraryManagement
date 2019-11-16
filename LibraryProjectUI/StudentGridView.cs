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
    public partial class StudentGridView : Form
    {
        public StudentGridView()
        {
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ProjectPracticeEntities db = new ProjectPracticeEntities();
        public void Search(string Student)
        {
            var students = db.tblStudents.Where(a => a.Fullname.Contains(Student)).Select(a => new {StudentId = a.StudenId , Fullname = a.Fullname, Gender = a.Gender, PhoneNo = a.PhoneNo , Email= a.Email}).ToList();
            //StudentData.DataSource = students;
            int n = 0;
            foreach(var std in students)
            {
                n = StudentData.Rows.Add();
                StudentData.Rows[n].Cells[0].Value = std.StudentId;
                StudentData.Rows[n].Cells[1].Value = std.Fullname;
                StudentData.Rows[n].Cells[2].Value = std.Gender;
                StudentData.Rows[n].Cells[3].Value = std.PhoneNo;
                StudentData.Rows[n].Cells[4].Value = std.Email;

            }
        }

        private void StudentGridView_Load(object sender, EventArgs e)
        {
            StudentData.BorderStyle = BorderStyle.None;
            StudentData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            StudentData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StudentData.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            StudentData.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            StudentData.BackgroundColor = Color.White;

            StudentData.EnableHeadersVisualStyles = false;
            StudentData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            StudentData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            StudentData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
       
        private void StudentData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int StudentId = Convert.ToInt32(StudentData.CurrentRow.Cells[0].Value);
            tblStudent tbs = db.tblStudents.Where(a => a.StudenId == StudentId).FirstOrDefault();
            ManageStudent ms = new ManageStudent();

            
            ms.btnSave.Enabled = false;

            ms.txtFullname.Text = tbs.Fullname.ToString();
            if (tbs.Gender.ToString() == "Male")
            {
                ms.rbdMale.Checked = true;
            }
            else
            {
                ms.rbdFemale.Checked = true;
            }
            ms.txtRollNo.Text = tbs.RollNo;
            ms.txtPhoneNo.Text = tbs.PhoneNo;
            ms.txtEmail.Text = tbs.Email;

            this.DialogResult = DialogResult.OK;


        }
    }
}
