using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySys
{
    public partial class ReturnBooks : Form
    { 
        Memberr member;
        public ReturnBooks(string ID, string name, string phonenumber, string address, int age, string gender)
        {
            InitializeComponent();
            tkDataContext tk = new tkDataContext();
            var mem = (from s in tk.tbl_Members where s.ID == ID select s).FirstOrDefault();
            if (mem != null)
                member = new Memberr(ID, name, age, phonenumber, address, gender);

            member.printDetail(lb_ID,lb_name,lb_age,lb_phone,lb_address,lb_gender);
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            member.returnBook(lb_ID.Text, txt_ISBN.Text);
        }
        private void ReturnBooks_Load(object sender, EventArgs e)
        {
        }
    }
}
