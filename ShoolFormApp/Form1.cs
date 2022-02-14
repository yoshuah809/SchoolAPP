using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace ShoolFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void btnPush_Click(object sender, EventArgs e)
        {
            var tSchool = new School();

            tSchool.Name = txtName.Text;
            tSchool.Address = txtAddress.Text;
            tSchool.City = txtCity.Text;
            tSchool.State = txtState.Text;
            tSchool.Zip = txtZip.Text;
            tSchool.PhoneNumber = tSchool.PhoneNumber;
            try
            {
                tSchool.TwitterAddress = txtTwitter.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(tSchool.ToString());
        
            var student = new Student();

            var teacher = new Teacher(); // remove later, thi is to test only
        
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();

            MessageBox.Show($"The Teacher Grade Average is {gp}");
        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();

            MessageBox.Show($"The Student Grade Average is {gp}");

        }
    }
}
