using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscribanoBackend.Models
{
    public class User
    {
        public int ID_User { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
    }
}