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
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
