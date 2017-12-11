using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class SickList
    {
        public int Id { get; set; }
        public int BeginDate { get; set; }
        public int EndDate { get; set; }
        public string Recommendations { get; set; }
        public string Diagnosis { get; set; }
        public int UserId { get; set; }
    }
}