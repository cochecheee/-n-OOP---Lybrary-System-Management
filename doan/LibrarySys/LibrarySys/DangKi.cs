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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            int tuoi;
            if(!int.TryParse(txt_tuoi.Text,out tuoi))
            {
                MessageBox.Show("Invalid age!");
                return;
            }
            HoatDong.Signup(txtConfirmPass.Text, txtPassword.Text, txtUsername.Text, txt_ID.Text, txt_ten.Text, txt_sdt.Text, txt_diachi.Text, tuoi,txt_gioitinh.Text,radio_librarian,radio_member );
        }
    }
}
