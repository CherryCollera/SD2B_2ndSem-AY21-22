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
    public partial class Form4 : Form
    {
        double a, b;
        public Form4()
        {
            InitializeComponent();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtFirstnumber.Text);
            b = Convert.ToDouble(txtSecondnumber.Text);
            txtAnswer.Text = (a - b).ToString();
        }

        private void times_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtFirstnumber.Text);
            b = Convert.ToDouble(txtSecondnumber.Text);
            txtAnswer.Text = (a * b).ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtFirstnumber.Text);
            b = Convert.ToDouble(txtSecondnumber.Text);
            txtAnswer.Text = (a / b).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 back = new Form3();
            back.Show();
            this.Hide();
        }


        private void plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtFirstnumber.Text);
            b = Convert.ToDouble(txtSecondnumber.Text);
            txtAnswer.Text = (a + b).ToString();
        }
    }
}
