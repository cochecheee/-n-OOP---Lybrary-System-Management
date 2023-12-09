using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace LibrarySys
{
    static class HoatDong
    {
        static tkDataContext db = new tkDataContext();
        public static void Login(RadioButton librarian, RadioButton member, string user, string pass, Form h)
        {
            try
            {
                if (librarian.Checked == true)
                {
                    tbl_Librarian li = new tbl_Librarian();
                    if (user != "" && pass != "")
                    {
                        var ad =db.tbl_Librarians.Where(s=>s.Username == user && s.Password == pass).FirstOrDefault();
                        if (ad != null)
                        {
                            MessageBox.Show("Logged in successfully");
                            h.Hide();
                            Form f = new LibrarianGUI(user);
                            f.Show();
                        }
                       else
                            MessageBox.Show("Account or password is incorrect.");
                    }
                    else
                    {
                        MessageBox.Show("Please enter complete data");
                    }
                }
                else
                {
                    if (member.Checked == true)
                    {
                        tbl_Member me = new tbl_Member();
                        if (user != "" && pass != "")
                        {
                            var ad = db.tbl_Members.Where(s => s.Username == user && s.Password == pass).FirstOrDefault();
                            if (ad != null)
                            {
                                MessageBox.Show("Logged in successfully");
                                h.Hide();
                                Form f = new MemberGUI(user);
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Account or password is incorrect.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter complete data!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose data!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
         public static void Signup(string confirm, string pass, string user, string ID, string ten, string phone, string diachi, int tuoi, string gioi,  RadioButton li, RadioButton me)
        {
            bool ktphone = true;
            if (phone.Length <10 ) 
            {
                MessageBox.Show("SĐT phải có ít nhất 10 chữ số"); // SĐT ở Việt Nam phải có ít nhất 10 chữ số
                return;
            }    
            for (int i = 0; i< phone.Length; i++)
            {
                if (phone[i] -'0' < 0 || phone[i]-'0' > 9) // Nếu có bất kì kí tự chữ nào thì là sai
                    ktphone = false;
            }
            if (ktphone== false) {
                MessageBox.Show("SĐT không hợp lệ!");
                return;
            }
            int dem = 0;
            for (int i = 0; i < diachi.Length; i++)
            {
                if ((diachi[i] >= 'a' && diachi[i] <= 'z') || (diachi[i] >= 'A' && diachi[i] <= 'Z')) // Nếu địa chỉ có ít hơn 3 kí tự chữ thì không hợp lệ, phải k, hay địa chỉ phải sao
                {
                    dem++; //cho dk này đại chỉ có số cx dc mà, m còn ghi 182 âu cơ j đó, t cho ghi đc mà má, chỉ có nhập số không thì mới k đc
                }
            }
            if (dem < 3)// Hà nội nó xác nhận 3 kí tự, chữ có dấu nó k tính
            {
                MessageBox.Show("Địa chỉ không hợp lệ."); // Ít nhất cũng phải ghi Tỉnh, Hà Nội
                return;
            } 
            if( gioi != "Nam" && gioi != "nam"&& gioi != "NAM" && gioi != "Nữ" && gioi!= "Nu" && gioi !="NU"&& gioi != "NỮ" && gioi != "nu"&&
                gioi != "female" && gioi !="Female"&& gioi !="FEMALE" && gioi != "Male" && gioi !="MALE" && gioi != "male")
            {
                MessageBox.Show("Giới tính không hợp lệ.");
                return;
            }

            if (ten[0]==' ')
            {
                MessageBox.Show("Tên không hợp lệ!");
                return;
            }
            for (int i = 0; i < ten.Length; i++)
            {
                if ((ten[i] < 'a' || ten[i] > 'z') && (ten[i] < 'A' ||ten[i] > 'Z') || (ten[i]==' ' && ten[i+1]==' '))
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    return;
                }    
            }
                
                
            var usernameExists = db.tbl_Librarians.Where(s => s.Username == user).FirstOrDefault(); // sử dụng lamda expression để là gọn nếu có bất cứ username nào trong librarian = user thì biến là true
            var usernameExistsM = db.tbl_Members.Where(s => s.Username == user).FirstOrDefault();
                                                                                                    /*bool usernameExists = db.tbl_Librarians.Any(
                                                                                                        (Librarian s) =>
                                                                                                        {
                                                                                                            return s.Username == user;
                                                                                                        }
                                                                                                    );*/
            if (confirm != pass)
            {
                MessageBox.Show("Password and confirmation password do not match.");    // Kiểm tra mật khẩu và xác nhận mật khẩu
                return;
            }
            if (user == "" || pass == "" || confirm == "" || ID == "" || ten == "" || diachi == "" || tuoi.ToString() == "" || gioi == "")
            {
                MessageBox.Show("Please enter complete data.");
            }
            else
            {

                if (tuoi >= 5)
                {
                    try
                    {

                        if (li.Checked == true)
                        {
                            tbl_Librarian tb = new tbl_Librarian();
                            tkDataContext db = new tkDataContext();

                            var existID = (from s in db.tbl_Librarians where s.ID == ID select s).FirstOrDefault();
                            if (existID!=null)
                            {
                                MessageBox.Show("Đã có ID! Nhập Id khác!");
                                return;
                            }

                               
                                if (usernameExists != null || usernameExistsM != null)
                                {
                                    MessageBox.Show("Account already exists!");
                                    return;
                                }
                                else
                                {
                                    tb.ID = ID;
                                    tb.Name = ten;
                                    tb.Age = tuoi;
                                    tb.Phonenumber = phone;
                                    tb.Address = diachi;
                                    tb.Gender = gioi;
                                    tb.Username = user;
                                    tb.Password = confirm;
                                    db.tbl_Librarians.InsertOnSubmit(tb);
                                    db.SubmitChanges();
                                    MessageBox.Show("Account created successfully, please log in again!");
                                }
                        }
                        else
                            if (me.Checked == true)
                            {
                            tbl_Member tb = new tbl_Member();
                            tkDataContext db = new tkDataContext();

                            var existID = (from s in db.tbl_Librarians where s.ID == ID select s).FirstOrDefault();
                            if (existID != null)
                            {
                                MessageBox.Show("Đã có ID! Nhập Id khác!");
                                return;
                            }
                                if (usernameExistsM != null || usernameExists != null)
                            {
                                    MessageBox.Show("Account already exists!");
                                return;
                                }
                                else
                                {
                                    tb.ID = ID;
                                    tb.Name = ten;
                                    tb.Age = tuoi;
                                    tb.Phonenumber = phone;
                                    tb.Address = diachi;
                                    tb.Gender = gioi;
                                    tb.Username = user;
                                    tb.Password = confirm;
                                    db.tbl_Members.InsertOnSubmit(tb);
                                    db.SubmitChanges();
                                    MessageBox.Show("Account created successfully, please log in again!");
                                }
                            

                            }
                            else
                                MessageBox.Show("Please enter complete data.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Note: You must be older than 5 years old.");
                }
            }

        }
    }

      
}

