using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class PrivateInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public int BirthDate { get; set; }

        public string Passport { get; set; }
        public int UserId { get; set; }

    }
}