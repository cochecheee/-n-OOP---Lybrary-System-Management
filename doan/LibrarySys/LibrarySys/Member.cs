using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace LibrarySys
{
    public class Memberr : Person, ActionMember
    {
        issuereturnDataContext issue = new issuereturnDataContext();

        bookDataContext book = new bookDataContext();
        tkDataContext tk = new tkDataContext();
        Operate op = new Operate();
        tbl_IssueBook issueBook1;
        tbl_ReturnBook1 returnBook1;
        public Memberr(string id, string name, int age, string phonenumber, string address, string gender)
            : base(id, name, age, phonenumber, address, gender) { }
        public override void printDetail(Label lb_ID, Label lb_name, Label lb_age, Label lb_phone,
            Label lb_address, Label lb_gender)
        {
            base.printDetail(lb_ID, lb_name, lb_age, lb_phone, lb_address, lb_gender);
        }
        public void issueBook(string ID, string isbn)
        {
            try
            {
                var nguoimuon = (from s in tk.tbl_Members where s.ID == ID select s).FirstOrDefault();
                if (nguoimuon == null)
                {
                    MessageBox.Show("This member's ID does not exist, please check again!");
                    return;
                }
                else
                {
                    var sachmuon = (from b in book.tbl_saches where b.ISBN == isbn select b).FirstOrDefault();
                    if (sachmuon == null)
                    {
                        MessageBox.Show("The book you want is currently not in the library!");
                        return;
                    }
                    else
                    {
                        issueBook1 = new tbl_IssueBook();
                        issueBook1.ID = nguoimuon.ID;
                        issueBook1.Name = nguoimuon.Name;
                        issueBook1.Phonenumber = nguoimuon.Phonenumber;
                        issueBook1.Address = nguoimuon.Address;
                        issueBook1.Age = nguoimuon.Age;
                        issueBook1.Gender = nguoimuon.Gender;
                        issueBook1.ISBN = sachmuon.ISBN;
                        issueBook1.Tittle = sachmuon.Tittle;
                        issueBook1.Author = sachmuon.Author;
                        issueBook1.Manufacturer = sachmuon.Manufacturer;
                        issueBook1.DateIssue = DateTime.Now.ToString();

                        if (isbn == "9786043874785" || isbn == "12345" || isbn == "9786041197060")
                        {
                            op.Issuing(isbn, "9786043874785");
                            op.Issuing(isbn, "12345");
                            op.Issuing(isbn, "9786041197060");
                            return;
                        }
                        issue.tbl_IssueBooks.InsertOnSubmit(issueBook1);
                        op.Issuing(isbn);
                        issue.SubmitChanges();
                        book.SubmitChanges();
                        MessageBox.Show("Borrow successfully!");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void returnBook(string ID, string isbn)
        {
            try
            {
                var nguoitra = (from s in issue.tbl_IssueBooks where s.ISBN == isbn select s).FirstOrDefault();
                if (nguoitra == null)
                {
                    MessageBox.Show("You don't borrow books from the library");
                }
                else
                {
                    returnBook1 = new tbl_ReturnBook1();
                    returnBook1.ID = ID;
                    returnBook1.Name = nguoitra.Name;
                    returnBook1.Phonenumber = nguoitra.Phonenumber;
                    returnBook1.Address = nguoitra.Address;
                    returnBook1.Age = nguoitra.Age;
                    returnBook1.Gender = nguoitra.Gender;
                    returnBook1.ISBN = nguoitra.ISBN;
                    returnBook1.Tittle = nguoitra.Tittle;
                    returnBook1.Author = nguoitra.Author;
                    returnBook1.Manufacturer = nguoitra.Manufacturer;
                    returnBook1.DateReturn = DateTime.Now.ToString();

                    DateTime dateis = Convert.ToDateTime(nguoitra.DateIssue);
                    DateTime datere = Convert.ToDateTime(returnBook1.DateReturn);
                    TimeSpan temp = datere - dateis; // TimeSpan là thời gian chênh lệnh giữa 2 khoảng thời gian DateTime (vd 12/6/2023 2:40:03 - 10/6/2023 4:39:01 = 61.02:1:2)
                  
                    if (datere > dateis.AddDays(30))
                    {
                        DialogResult result = MessageBox.Show("You are overdue for your book return, you need to pay more:" + temp.Days * 1000 + " VND. Select Yes to pay, No not to pay.", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            issue.tbl_ReturnBook1s.InsertOnSubmit(returnBook1);
                            op.Returning(isbn, nguoitra.Tittle, nguoitra.Author, nguoitra.Manufacturer);
                            issue.tbl_IssueBooks.DeleteOnSubmit(nguoitra);

                            issue.SubmitChanges();
                            book.SubmitChanges();
                            MessageBox.Show("Return successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Book return failed because you haven't paid yet!");
                        }
                    }
                    else
                    {
                        issue.tbl_ReturnBook1s.InsertOnSubmit(returnBook1);
                        op.Returning(isbn, nguoitra.Tittle, nguoitra.Author, nguoitra.Manufacturer);
                        issue.tbl_IssueBooks.DeleteOnSubmit(nguoitra);

                        issue.SubmitChanges();
                        book.SubmitChanges();
                        MessageBox.Show("Return successfully!");
                    }
             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}