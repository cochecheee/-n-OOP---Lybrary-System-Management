using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace LibrarySys
{
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
            rtbNoiQuy.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            rtbNoiQuy.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap login = new DangNhap();
            login.Show();
        }

    }
}
