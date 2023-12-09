using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XuatFile;

namespace LibrarySys
{
    public class Librarian : Person, ActionLibrarian
    {

        private string username;
        private string password;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Librarian(string id, string name, int age, string phonenumber, string address, string gender, string username, string password)
            : base(id, name, age, phonenumber, address, gender)
        {
            Username = username;
            Password = password;
        }

        tbl_sach tb = new tbl_sach();
        bookDataContext db = new bookDataContext();
        Operate op = new Operate();
        tbl_IssueBook iss = new tbl_IssueBook();
        issuereturnDataContext ir = new issuereturnDataContext();
        public override void printDetail(Label lb_ID, Label lb_name, Label lb_age, Label lb_phone,
           Label lb_address, Label lb_gender)
        {
            base.printDetail(lb_ID, lb_name, lb_age, lb_phone, lb_address, lb_gender);
        }
        //trien khai interface 
        public void addBook(string ISBN, string Tittle, string Author, string Manufacturer)
        {
            try 
            {
                if (ISBN == "" || Tittle == "" || Author == "" || Manufacturer == "")
                {
                    MessageBox.Show("Please enter complete data");
                } 
                else
                {
                    var temp = db.tbl_saches.Where(s => s.ISBN == ISBN).FirstOrDefault();
                    var muonExist = ir.tbl_IssueBooks.Where(s=> s.ISBN == ISBN).FirstOrDefault();
                    if (temp == null && muonExist ==null)
                    {
                        op.Adding(ISBN, Tittle, Author, Manufacturer);
                        MessageBox.Show("Added sucessfully.");
                    }
                    else
                    {
                        MessageBox.Show("Existed ISBN of book!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void viewMemberDetail(string memID,DataGridView dtgv,DataGridView dtgv1) 
        {
            try
            {
                issuereturnDataContext iss = new issuereturnDataContext();
                var Lst = (from s in iss.tbl_IssueBooks where s.ID.Contains(memID) select s).ToList();
                dtgv.DataSource = Lst;
                var Lst1 = (from s in iss.Members where s.ID.Contains(memID) select s).ToList();
                dtgv1.DataSource = Lst1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //thực hiện in dữ liệu trong database
        public void GenerateReport(DataGridView dtgv)
        {
            XuatFile.XuatFile.ExportToExcel(dtgv, @"D:\OOP\DoAn"); 
        }
    }
}