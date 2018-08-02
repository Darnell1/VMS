using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin1.Models
{
    public class User
    {
        [Key]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Centers { get; set; }
        public String Skills { get; set; }
        public String Availability { get; set; }
        public String Address { get; set; }
        public int Number { get; set; }
        public String Email { get; set; }
        public String Education { get; set; }
        public String Licenses { get; set; }
        public String ContactName { get; set; }
        public int ContactPhone { get; set; }
        public String ContactAddress { get; set; }
        public String DriversLicense { get; set; }
        public String SocialSecurity { get; set; }
        public String ApprovalStatus { get; set; }
    }
}
