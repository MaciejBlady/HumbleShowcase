using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAKid
{
    public partial class ShowKidsForm : Form
    {
        public ShowKidsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var frm = new MainForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowKidsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theRAKDatabaseDataSet.Dzieci' table. You can move, or remove it, as needed.
            this.dzieciTableAdapter.Fill(this.theRAKDatabaseDataSet.Dzieci);


            
        }

        private void dzieciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dzieciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theRAKDatabaseDataSet);

        }

        private void dzieciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
