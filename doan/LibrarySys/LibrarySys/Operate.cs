using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySys
{
    public class Operate
    {  
        tbl_sach sach;
        bookDataContext db = new bookDataContext();
        public void Issuing(string x)
        {
            try
            {
                {
                    sach = new tbl_sach();
                    sach = db.tbl_saches.Where(s => s.ISBN == x).First();
                    db.tbl_saches.DeleteOnSubmit(sach);

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue Error:" + ex.Message);
            }
        }
        public void Issuing (string x, string y)
        {
            if ( x== y)
                MessageBox.Show("Books only use in library.");
            return;
        }
        public void Returning(string ISBN, string tittle, string author, string manufacturer)
        {
            try
            {
                sach = new tbl_sach();
                sach.ISBN = ISBN;
                sach.Tittle = tittle;
                sach.Author = author;
                sach.Manufacturer = manufacturer;
                db.tbl_saches.InsertOnSubmit(sach);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Return Error:" + ex.Message);
            }
        }
        public void Removing(string x)
        {
            try
            {
                sach = new tbl_sach();
                sach = db.tbl_saches.Where(s => s.ISBN == x).First();
                db.tbl_saches.DeleteOnSubmit(sach);

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Remove Error:" + ex.Message);
            }
        }
        public void Adding(string ISBN, string tittle, string author, string manufacturer)
        {
            try
            {
                sach = new tbl_sach();
                sach.ISBN = ISBN;
                sach.Tittle = tittle;
                sach.Author = author;
                sach.Manufacturer = manufacturer;
                db.tbl_saches.InsertOnSubmit(sach);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Error:" + ex.Message);
            }
        }
    }
}
