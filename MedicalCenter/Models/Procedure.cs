using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Procedure
    {
        public int Id { get; set; }

        public int Date { get; set; }

        public int Cost { get; set; }

        public int Time { get; set; }

        public int Cabinet { get; set; }

        public int UserId { get; set; }

        public int ServiceId { get; set; }

    }
}