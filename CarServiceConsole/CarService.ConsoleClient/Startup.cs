namespace CarService.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CarService.Data;
    using CarService.Models;
    using System.Data.Entity;
    using Data.Migrations;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var db = new CarServiceDbContext();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarServiceDbContext, Configuration>());

            var user = new User { Name = "Ivan", Address = "Sofiq", Gender = Gender.Male  };

            db.Users.Add(user);



            db.SaveChanges();
        }
    }
}
