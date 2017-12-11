using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class MainContext : DbContext
    {
        public DbSet<Analysis> Analysis { get; set; }
        public DbSet<DiseaseHistory> DiseaseHistory { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<DrugAccounter> DrugAccounter { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PrivateInfo> PrivateInfo { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<Records> AnaRecordslysis { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<SickList> SickList { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<Worktime> Worktime { get; set; }

    }
}