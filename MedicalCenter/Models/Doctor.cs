using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Speciality { get; set; }

        public string Department { get; set; }
        
        public int Post { get; set; }

        public string Category { get; set; }

        public int UserId { get; set; }

    }
}