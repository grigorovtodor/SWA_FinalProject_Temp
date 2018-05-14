namespace CarService.Data
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Text;

    public class CarServiceDbContext : DbContext
    {
        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<RepairWork> RepairWorks { get; set; }

        public virtual IDbSet<Brand> Brands { get; set; }

        public virtual IDbSet<Model> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
