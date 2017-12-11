using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int Cabinet { get; set; }
        public int DoctorId { get; set; }

    }
}