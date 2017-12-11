using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class DrugAccounter
    {
        public int Id { get; set; }

        public string DrugGroup { get; set; }

        public string Name { get; set; }

        public string Amount { get; set; }

        public int Date { get; set; }

        public int UserId { get; set; }
    }
}