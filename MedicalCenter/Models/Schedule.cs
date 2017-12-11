using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int NumberClientsEven { get; set; }
        public int NumberClientsUneven { get; set; }
        public int WorktimeId { get; set; }

    }
}