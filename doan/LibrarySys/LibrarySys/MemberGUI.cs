using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySys
{
    public partial class MemberGUI : Form
    {
        private Memberr member;
        tkDataContext tk = new tkDataContext();
        public MemberGUI(string Username)
        {
            InitializeComponent();
            lb_username.Text = Username;
            var mem = (from s in tk.tbl_Members where s.Username == Username select s).FirstOrDefault();
            member = new Memberr(mem.ID, mem.Name,mem.Age, mem.Phonenumber, mem.Address, mem.Gender);
            pn_ISBN.Hide();
            pn_searchtittle.Hide();
            pn_searchauthor.Hide();
        }
        private void tsbtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            this.Close();
        }
        private void MemberGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnDataSet.tbl_sach' table. You can move, or remove it, as needed.
            this.tbl_sachTableAdapter.Fill(this.doAnDataSet.tbl_sach);
        }

        private void txt_tktittle_TextChanged(object sender, EventArgs e)
        {
            member.searchBook(txt_tktittle.Text, dataGridView1,false,true,false);
            MemberGUI_Load(sender, e);
        }
        private void txt_tkauthor_TextChanged(object sender, EventArgs e)
        {
            member.searchBook(txt_tkauthor.Text, dataGridView1, false, false, true);
            MemberGUI_Load(sender, e);
        }
       
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            member.searchBook(txt_tkISBN.Text, dataGridView1, true, false, false);
            MemberGUI_Load(sender, e);

        }
        private void searchISBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pn_ISBN.Show();
            pn_searchtittle.Hide();
            pn_searchauthor.Hide();
        }
        private void seachTittleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pn_ISBN.Hide();
            pn_searchtittle.Show();
            pn_searchauthor.Hide();
        }
        private void seaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pn_ISBN.Hide();
            pn_searchtittle.Hide();
            pn_searchauthor.Show();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pn_ISBN.Hide();
            pn_searchtittle.Hide();
            pn_searchauthor.Hide();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var mem = (from s in tk.tbl_Members where s.Username == lb_username.Text select s).FirstOrDefault();
            IssueBooks issueBooks = new IssueBooks(mem.ID, mem.Name, mem.Phonenumber, mem.Address, mem.Age, mem.Gender);
            issueBooks.FormClosed += IssueBooks_FormClosed;
            issueBooks.Show();
        }
        private void IssueBooks_FormClosed(object sender, EventArgs e)
        {
            MemberGUI_Load(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var mem = (from s in tk.tbl_Members where s.Username == lb_username.Text select s).FirstOrDefault();
            ReturnBooks re = new ReturnBooks(mem.ID,mem.Name,mem.Phonenumber,mem.Address,mem.Age,mem.Gender);
            re.FormClosed += ReturnBooks_FormClosed;
            re.Show();
        }
        private void ReturnBooks_FormClosed(object sender, EventArgs e)
        {
            MemberGUI_Load(sender, e);
        }
    }
}