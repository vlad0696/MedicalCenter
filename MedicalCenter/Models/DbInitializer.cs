using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedicalCenter.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<MainContext>
    {
        protected override void Seed(MainContext db)
        {
            db.Role.Add(new Role { UserRole = "Врач" });
            db.Role.Add(new Role { UserRole = "Пользователь" });
            db.Role.Add(new Role { UserRole = "Персонал"});
            db.Role.Add(new Role { UserRole = "Администратор"});

            base.Seed(db);
        }
    }
}