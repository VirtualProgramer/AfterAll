using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfterAll.Models {
    public class Member {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birth { get; set; }
        public int Phone { get; set; }
        public int AccessLevel { get; set; }
    }
}