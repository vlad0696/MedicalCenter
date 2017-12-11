using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Records
    {
        public int Id { get; set; }
        public int Date { get; set; }
        public int Tikets { get; set; }
        public int UserId { get; set; }
    }
}