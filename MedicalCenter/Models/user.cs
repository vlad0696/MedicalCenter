using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string TempPassword { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }

    }
}