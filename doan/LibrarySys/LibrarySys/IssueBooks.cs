using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySys
{
    public partial class IssueBooks : Form // ủa v là m k xài hàm operate hả //hình như có mà có mấy cái xài //tí xem 1 lượt thử coi, sao giờ k xem? //m đang sửa mà sửa r, chỗ nào nữa
    {
        Memberr member;
        tkDataContext tk = new tkDataContext();
        public IssueBooks(string ID, string name, string phonenumber, string address, int age, string gender)
        {
            InitializeComponent();
            var mem = (from s in tk.tbl_Members where s.ID == ID select s).FirstOrDefault();
            if (mem != null)
                member = new Memberr(ID, name, age, phonenumber, address, gender );
            member.printDetail(lb_ID,lb_name,lb_phone,lb_address, lb_age, lb_gender);
        }
        private void btn_issue_Click(object sender, EventArgs e)
        {
             member.issueBook(lb_ID.Text,txt_ISBN.Text);
        }
        private void IssueBooks_Load(object sender, EventArgs e)
        {

        }

       
    }
}
