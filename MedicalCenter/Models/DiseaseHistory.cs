using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class DiseaseHistory
    {
        public int Id { get; set; }

        public string Anamnesis { get; set; }

        public int UserId { get; set; }

        public int VisitId { get; set; }
    }

}