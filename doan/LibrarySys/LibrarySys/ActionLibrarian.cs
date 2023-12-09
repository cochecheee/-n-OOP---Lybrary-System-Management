using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrarySys
{
    public interface ActionLibrarian
    {
        void addBook(string ISBN, string Tittle, string Author, string Manufacturer);
        void viewMemberDetail(string memID, DataGridView dtgv,DataGridView dtgv1);
        void GenerateReport(DataGridView dtgv);
    }
}