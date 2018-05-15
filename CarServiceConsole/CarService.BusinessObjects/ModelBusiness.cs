namespace CarService.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ModelBusiness
    {
        private BrandBusiness brand;

        public ModelBusiness(string name, BrandBusiness brand)
        {
            this.Name = name;
            this.Brand = brand;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public BrandBusiness Brand { get; set; }
    }
}
