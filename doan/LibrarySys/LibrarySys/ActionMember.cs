using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrarySys
{
    public interface ActionMember 
    {

        void issueBook(string ID, string isbn);
        void returnBook(string ID, string isbn);

    }
}