using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAdminWebSite.Models
{
    public class UserLoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public bool RememberMe { get; set; }
    }
}