using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LibrarySys
{
    public abstract class Person 
    {
        private string id;
        private string name;
        private int age;
        private string phonenumber;
        private string address;
        private string gender;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
        public Person(string id, string name, int age, string phonenumber, string address, string gerder)
        {
            Id = id;
            Name = name;
            Age = age;
            Phonenumber = phonenumber;
            Address = address;
            Gender = gerder;
        }
        public Person() { }
        public virtual void printDetail(Label lb_ID, Label lb_name, Label lb_age, Label lb_phone,
            Label lb_address, Label lb_gender) 
        {
            lb_ID.Text = Id;
            lb_name.Text = Name;
            lb_age.Text = Age.ToString();
            lb_gender.Text = Gender.ToString();
            lb_phone.Text = Phonenumber;
            lb_address.Text = Address.ToString();
        }

        //nạp chồng overload
        public void searchBook(string criteria1, DataGridView dgv, bool a, bool b, bool c) 
        {
            bookDataContext db = new bookDataContext();
            
            try
            {
                if (a == true)
                {
                    var Lst1 = (from s in db.tbl_saches where s.ISBN.Contains(criteria1) select s).ToList();
                    if (Lst1 != null)
                    {
                        dgv.DataSource = Lst1;
                    }
                }
                else if (b == true)
                {
                    var Lst2 = (from s in db.tbl_saches where s.Tittle.Contains(criteria1) select s).ToList();
                    if (Lst2 != null)
                    {
                        dgv.DataSource = Lst2;
                    }
                }
                else if(c == true)
                {    
                    var Lst3 = (from s in db.tbl_saches where s.Author.Contains(criteria1) select s).ToList();
                    if (Lst3 != null)
                    {
                        dgv.DataSource = Lst3;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchBook(string criteria1, DataGridView dgv, RadioButton a, RadioButton b, RadioButton c)
        {
            bookDataContext db = new bookDataContext();

            try
            {
                //sai nè?
                if (a.Checked == true)
                {
                    var Lst1 = (from s in db.tbl_saches where s.ISBN.Contains(criteria1) select s).ToList();
                    if (Lst1 != null)
                    {
                        dgv.DataSource = Lst1;
                    }
                }
                else if (b.Checked == true)
                {
                    var Lst2 = (from s in db.tbl_saches where s.Tittle.Contains(criteria1) select s).ToList();
                    if (Lst2 != null)
                    {
                        dgv.DataSource = Lst2;
                    }
                }
                else
                {
                    if (c.Checked == true)
                    {
                        var Lst3 = (from s in db.tbl_saches where s.Author.Contains(criteria1) select s).ToList();
                        if (Lst3 != null)
                        {
                            dgv.DataSource = Lst3;
                        }
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