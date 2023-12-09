using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LibrarySys
{
    
    public partial class DangNhap : Form
    {
       
       
        public DangNhap()
        {
            InitializeComponent();
        }   
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            HoatDong.Login(radio_librarian, radio_member, txtUsername.Text, txtPassword.Text, DangNhap.ActiveForm);
        }
        private void btnsignup_Click_1(object sender, EventArgs e)
        {

            DangKi dangKi = new DangKi();
            dangKi.Show();
        }
    }
}
