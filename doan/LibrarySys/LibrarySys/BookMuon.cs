using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySys
{
    public class BookMuon : Book
    {
        DateTime ngaymuon;
        DateTime hantra;

        public DateTime Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public DateTime Hantra { get => hantra; set => hantra = value; }

        public BookMuon(DateTime ngaymuon, DateTime hantra, string tensach, string masach, string tacgia,string isbn,int soluong)
            :base(tensach, masach, tacgia, isbn, soluong)
        {
            Ngaymuon = ngaymuon;
            Hantra = hantra;
        }
    }
}