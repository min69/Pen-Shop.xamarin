using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace shop.TABLE
{
    public class LIST
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
