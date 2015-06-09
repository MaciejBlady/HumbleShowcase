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
    public partial class ShowBookingsForm : Form
    {
        public ShowBookingsForm()
        {
            InitializeComponent();
        }

        private void wypozyczeniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wypozyczeniaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theRAKDatabaseDataSet);

        }

        private void ShowBookingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theRAKDatabaseDataSet.Wypozyczenia' table. You can move, or remove it, as needed.
            this.wypozyczeniaTableAdapter.Fill(this.theRAKDatabaseDataSet.Wypozyczenia);

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
    }
}
