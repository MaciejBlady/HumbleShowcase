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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private bool BookChild(int childId, int clientId, int hours)
        {
            int lendId = 1;
            bool alreadyBooked = false;
            const String status = "W";

            using (var db = new TheRAKDatabaseEntities())
            {
                var query = from b in db.Wypozyczenia
                            select b;
                //db.Dzieci.Find(childID);
                foreach (var item in query)
                {
                    lendId++;
                    //Dzieciak wypozyczony
                    if (item.IDDziecka == childId)
                    {
                        if (item.Status.Contains(status))
                        {
                            alreadyBooked = true;
                        }
                    }
                }

                if (alreadyBooked == false)
                {
                    int number = 0;
                    try
                    {
                        number = db.Wypozyczenia.OrderByDescending(m => m.IDWypozyczenia).FirstOrDefault().IDWypozyczenia;
                    }
                    catch (Exception)
                    {
                        number = 0;                     
                    }
                    
                    var newLendOut = new Wypozyczenia
                    {
                        
                        IDWypozyczenia = 1 + number,//db.Wypozyczenia.Count()+1,
                        IDDziecka = childId,
                        IDKlientaPodejmujacego = clientId,
                        Data = DateTime.Now,
                        Status = "W",
                        Godziny = hours
                    };

                    db.Wypozyczenia.Add(newLendOut);
                    db.Entry(newLendOut).State = EntityState.Added;
                    db.ChangeTracker.DetectChanges();
                    db.SaveChanges();
                    return true;
                }
                else
                {
                   MessageBox.Show("Nie mozna wypozyczyc wypozyczonego dziecka");
                   return false;
                }
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            int clientID = (int)clientIDNumericUpDown.Value;
            int childID = (int)childIDNumericUpDown.Value;
            int hours = (int)hoursNumericUpDown.Value;
            bool success = false;

            try
            {
                success = BookChild(childID, clientID, hours);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Błędne dane!");
                success = false;
            }
            

            if (success)
            {
                var frm = new MainForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
            }else
            {
                var frm = new BookForm();
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
    }
}
