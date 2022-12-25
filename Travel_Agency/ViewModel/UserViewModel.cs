using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel_Agency.Models;

namespace Travel_Agency.ViewModel
{
    public class UserViewModel
    {
        public User user { get; set; }
        public List<User> users { get; set; }
    }
}