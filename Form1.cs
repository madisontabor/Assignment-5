using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);
            this.personBindingSource.DataMember = "Person";


            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;

            nameTextBox.TabIndex = 0;
            phoneTextBox.TabIndex = 1;  
            saveButton.TabIndex = 2;
            addButton.TabIndex = 3;
            deleteButton.TabIndex = 4;

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.personBindingSource.RemoveCurrent();
            this.personTableAdapter.Update(this.personDataSet.Person);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.personBindingSource.AddNew();
        }
    }
}
