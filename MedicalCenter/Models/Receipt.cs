using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Receipt
    {
        public int  Id { get; set; }

        public string Drug { get; set; }

        public string TypeReceipt { get; set; }

        public string Dose { get; set; }

        public int DoctorId { get; set; }
    }
}