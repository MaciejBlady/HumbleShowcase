using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAKid
{
    public partial class AddChildForm : Form
    {
        public AddChildForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static void AddKid(int ownerID, String kidName, String kidSurname, String gender)
        {
            using (var db = new TheRAKDatabaseEntities())
            {
                var newKid = new Dzieci
                {
                    IDDziecka = db.Dzieci.Count()+1,
                    IDKlienta = ownerID,
                    Imie = kidName,
                    Nazwisko = kidSurname,
                    Plec = gender,
                };

                db.Dzieci.Add(newKid);
                db.Entry(newKid).State = EntityState.Added;
                db.ChangeTracker.DetectChanges();
                db.SaveChanges();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string gender = "M";
            bool error = false;

            if (girlRB.Checked)
            {
                gender = "K";
            }

            int clientID = (int)clientIDNmericUpDown.Value;
            try
            {
                AddKid(clientID, name, surname, gender);
            }
            catch (DbUpdateException)
            {
                error = true;
                MessageBox.Show("Błędne dane");

                var excFrm = new AddChildForm();
                excFrm.Location = this.Location;
                excFrm.StartPosition = FormStartPosition.Manual;
                excFrm.FormClosing += delegate { this.Close(); };
                excFrm.Show();
                this.Hide();
            }


            if (!error)
            {
                var frm = new MainForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide(); 
            }
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

        private void AddChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
