
namespace DatabaseConnection_Anilao_Casaña_Sese
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookrecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.book3DataSet1 = new DatabaseConnection_Anilao_Casaña_Sese.book3DataSet1();
            this.book3DataSet = new DatabaseConnection_Anilao_Casaña_Sese.book3DataSet();
            this.bookrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookrecordsTableAdapter = new DatabaseConnection_Anilao_Casaña_Sese.book3DataSetTableAdapters.bookrecordsTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bookrecordsTableAdapter1 = new DatabaseConnection_Anilao_Casaña_Sese.book3DataSet1TableAdapters.bookrecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Number: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(145, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(330, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(145, 54);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(330, 22);
            this.txtDesc.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(145, 84);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(330, 22);
            this.txtNumber.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.booknoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookrecordsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 178);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // booktitleDataGridViewTextBoxColumn
            // 
            this.booktitleDataGridViewTextBoxColumn.DataPropertyName = "booktitle";
            this.booktitleDataGridViewTextBoxColumn.HeaderText = "booktitle";
            this.booktitleDataGridViewTextBoxColumn.Name = "booktitleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // booknoDataGridViewTextBoxColumn
            // 
            this.booknoDataGridViewTextBoxColumn.DataPropertyName = "bookno";
            this.booknoDataGridViewTextBoxColumn.HeaderText = "bookno";
            this.booknoDataGridViewTextBoxColumn.Name = "booknoDataGridViewTextBoxColumn";
            // 
            // bookrecordsBindingSource1
            // 
            this.bookrecordsBindingSource1.DataMember = "bookrecords";
            this.bookrecordsBindingSource1.DataSource = this.book3DataSet1;
            // 
            // book3DataSet1
            // 
            this.book3DataSet1.DataSetName = "book3DataSet1";
            this.book3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book3DataSet
            // 
            this.book3DataSet.DataSetName = "book3DataSet";
            this.book3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrecordsBindingSource
            // 
            this.bookrecordsBindingSource.DataMember = "bookrecords";
            this.bookrecordsBindingSource.DataSource = this.book3DataSet;
            // 
            // bookrecordsTableAdapter
            // 
            this.bookrecordsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(500, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD NEW RECORD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Location = new System.Drawing.Point(500, 84);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(164, 50);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "VIEW ALL RECORD";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(500, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 50);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE RECORD";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(500, 196);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 50);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT RECORD";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(500, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE RECORD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bookrecordsTableAdapter1
            // 
            this.bookrecordsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(691, 325);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "    Book Monitoring System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private book3DataSet book3DataSet;
        private System.Windows.Forms.BindingSource bookrecordsBindingSource;
        private book3DataSetTableAdapters.bookrecordsTableAdapter bookrecordsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private book3DataSet1 book3DataSet1;
        private System.Windows.Forms.BindingSource bookrecordsBindingSource1;
        private book3DataSet1TableAdapters.bookrecordsTableAdapter bookrecordsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknoDataGridViewTextBoxColumn;
    }
}

