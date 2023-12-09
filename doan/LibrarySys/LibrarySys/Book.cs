using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySys
{
    public class Book
    {
        private string tensach;
        private string tacgia;
        private string isbn;
        private string manufacturer;
      
        public string Tensach { get => tensach; set => tensach = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
       
        public Book() { }
        public Book(string tensach, string tacgia, string isbn, string manufacturer)
        {
            Tensach = tensach;
            Tacgia = tacgia;
            Isbn = isbn;
            Manufacturer = manufacturer;
        }
    }
}