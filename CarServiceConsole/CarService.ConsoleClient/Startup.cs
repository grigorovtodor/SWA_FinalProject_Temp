namespace CarService.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CarService.Data;
    using CarService.Models;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var db = new CarServiceDbContext();

            var user = new User { Name = "Pesho" };

            db.Users.Add(user);



            db.SaveChanges();
        }
    }
}
