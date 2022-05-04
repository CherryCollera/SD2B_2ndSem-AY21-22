using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_borboran_mendoza_santos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            string a, b;
            a = txtFirstname.Text;
            b = txtLastname.Text;
            MessageBox.Show(GetMyProfile(a, b));
        }

        public string GetMyProfile(string firstname, string lastname)
        {
            return ("\t\tHello " + firstname + " " + lastname)
                    + "\nDate of Birth\t:\t" + "February 7, 2002"
                    + "\nCourse\t\t:\t" + "BS in Computer Science"
                    + "\nYear\t\t:\t" + "II"
                    + "\nSection\t\t:\t" + "SD2B";

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Form4 next = new Form4();
            next.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 back = new Form2();
            back.Show();
        }
    }
}
