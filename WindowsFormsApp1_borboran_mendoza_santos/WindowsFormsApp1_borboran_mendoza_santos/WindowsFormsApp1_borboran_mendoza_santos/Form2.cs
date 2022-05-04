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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            MessageBox.Show("Happy Birthday " + firstname + " " + lastname);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Form3 next = new Form3();
            next.Show();
            this.Hide();
        }
    }
}
