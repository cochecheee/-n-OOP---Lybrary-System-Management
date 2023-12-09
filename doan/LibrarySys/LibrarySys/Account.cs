using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySys
{
    public class Account1
    {
        private string username;
        private string password;
        private bool librarian;
        private bool member;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool Librarian { get => librarian; set => librarian = value; }
        public bool Member { get => member; set => member = value; }

        public Account1(string username, string password, bool lib, bool mem) {
            Username = username;
            Password = password;
            Librarian = lib;
            Member = mem;
        }
        public Account1() { }
        public void changePass()
        {

        }

        public void changeUsername()
        {

        }
    }
}
