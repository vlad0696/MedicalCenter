using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int Cost { get; set; }

        public int Date { get; set; }

        public int ProcedureId { get; set; }

    }
}