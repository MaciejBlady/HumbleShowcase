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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (addChildrenRB.Checked)
            {
                var frm = new AddChildForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
            }else 
                if (bookChildRB.Checked)
                {
                    var frm = new BookForm();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Close(); };
                    frm.Show();
                    this.Hide();
                }
                
        }

        private void showKidsButton_Click(object sender, EventArgs e)
        {
            var frm = new ShowKidsForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void showBookingsButton_Click(object sender, EventArgs e)
        {
            var frm = new ShowBookingsForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
