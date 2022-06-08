using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//namespace

namespace DatabaseConnection_Anilao_Casaña_Sese
{
    public partial class Form1 : Form
    {
        int id;
        //declaration for Oledb connection Oledb command
        private OleDbConnection bookConn;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        //provider and data source
        private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\regie\Desktop\Activity8_Anilao_Casaña_Sese\book3.accdb";
        //private String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\regee\Downloads\Activity8_Anilao_Casaña_Sese\book3.mdb";
        public Form1()
        {
            //instantiate
            bookConn = new OleDbConnection(connParam);
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book3DataSet1.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter1.Fill(this.book3DataSet1.bookrecords);
            // TODO: This line of code loads data into the 'book3DataSet.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter.Fill(this.book3DataSet.bookrecords);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bookConn.Open();
            oleDbCmd.Connection = bookConn;
            oleDbCmd.CommandText = "Insert into bookrecords (booktitle, description, bookno)" + " " + " values ('" + this.txtTitle.Text + "' , '" + this.txtDesc.Text + "' , '" + this.txtNumber.Text + "');";
            int temp = oleDbCmd.ExecuteNonQuery();
            if (temp > 0)
            {
                txtTitle.Text = null;
                txtDesc.Text = null;
                txtNumber.Text = null;
                MessageBox.Show("Record successfully added");

            }
            else
            {
                MessageBox.Show("Record Fail Added");
            }
            bookConn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            OleDbDataAdapter dAdapter = new OleDbDataAdapter("SELECT * FROM bookrecords", connParam);
            OleDbDataAdapter dAdapter1 = new OleDbDataAdapter("UPDATE * FROM bookrecords", connParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            DataTable datatable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(datatable);
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(datatable.Rows[i][0], datatable.Rows[i][1], datatable.Rows[i][2], datatable.Rows[i][3]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                bookConn.Open();
                oleDbCmd.Connection = bookConn;
                oleDbCmd.CommandText = "DELETE FROM bookrecords where ID =" + id;
                int temp = oleDbCmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    id = 0;
                    txtTitle.Text = null;
                    txtDesc.Text = null;
                    txtNumber.Text = null;
                    MessageBox.Show("Record successfully deleted");
                    MessageBox.Show("Press view all records to show updated list");

                }
                else
                {
                    MessageBox.Show("Record failed to be deleted");
                }
                bookConn.Close();
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            txtTitle.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtDesc.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtNumber.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Save Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bookConn.Open();
                oleDbCmd.Connection = bookConn;
                oleDbCmd.CommandText = "Update bookrecords set booktitle ='" + this.txtTitle.Text + "', description ='"
                    + this.txtDesc.Text + "', bookno = '" + this.txtNumber.Text + "' Where ID=" + id + "";
                int temp = oleDbCmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    txtTitle.Text = null;
                    txtDesc.Text = null;
                    txtNumber.Text = null;
                    MessageBox.Show("Record successfully updated");
                    MessageBox.Show("Press view all records to show updated list");

                }
                else
                {
                    MessageBox.Show("Record Failed to update");
                }
                bookConn.Close();
            }else
                txtTitle.Text = null;
                txtDesc.Text = null;
                txtNumber.Text = null;
                btnSave.Enabled = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTitle.Text = null;
                txtDesc.Text = null;
                txtNumber.Text = null;
                btnSave.Enabled = false;            

        }
    }
}
