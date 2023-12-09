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
using System.IO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using XuatFile;


namespace LibrarySys
{
    public partial class LibrarianGUI : Form
    {
        private Librarian librarian;
        public LibrarianGUI(string username)
        {
            InitializeComponent();
            lb_username.Text = username;
            tkDataContext tk = new tkDataContext();
            var lib = (from s in tk.tbl_Librarians where s.Username == username select s).FirstOrDefault();
            librarian = new Librarian(lib.ID, lib.Name, lib.Age, lib.Phonenumber, lib.Address,
                lib.Gender, lib.Username, lib.Password);
        }
        public LibrarianGUI() { }
        private void LibrarianGUI_Load(object sender, EventArgs e)
        {
            this.memberTableAdapter.Fill(this.doAnDataSet_member.Member);
            this.tbl_ReturnBook1TableAdapter.Fill(this.doAnDataSet_return.tbl_ReturnBook1);
            this.tbl_IssueBookTableAdapter.Fill(this.doAnDataSet_issue.tbl_IssueBook);
            this.tbl_sachTableAdapter.Fill(this.doAnDataSet.tbl_sach);
        }
        private void ID_TextChanged(object sender, EventArgs e)
        {
            librarian.viewMemberDetail(ID.Text, dtgv_member, dtgv_member1);
            LibrarianGUI_Load(sender, e);
        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            librarian.searchBook(txt_timkiem.Text, dtgv_book, radio_ISBN, radio_tittle, radio_author);
            LibrarianGUI_Load(sender, e);
        }
        private void btnPanelSach_Click(object sender, EventArgs e)
        {
            tab1.Show();
            tab2.Hide();
            tab3.Hide();
        }
        private void btnDocGia_Click(object sender, EventArgs e)
        {
            tab1.Hide();
            tab2.Show();
            tab3.Hide();
        }
        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            tab1.Hide();
            tab2.Hide();
            tab3.Show();
        }
        private void tsbtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            this.Close();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            librarian.printDetail(lb_ID, lb_name, lb_age, lb_phone, lb_address, lb_gender);
        }
        
        private void btn_Issue_Click(object sender, EventArgs e)
        {
            librarian.GenerateReport(dtgv_issue);
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            librarian.GenerateReport(dtgv_book);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            librarian.GenerateReport(dtgv_return);
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            librarian.GenerateReport(dtgv_member);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            librarian.addBook(txt_ISBN.Text, txt_tittle.Text, txt_author.Text, txt_manu.Text);
            LibrarianGUI_Load(sender, e);
            txt_ISBN.Text = ""; txt_tittle.Text = ""; txt_author.Text = ""; txt_manu.Text = "";
        }

        private void txt_tittle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_ID_Click(object sender, EventArgs e)
        {

        }
    } 
}
