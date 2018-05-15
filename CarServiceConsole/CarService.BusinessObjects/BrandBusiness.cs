namespace CarService.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BrandBusiness
    {
        private string name;

        public BrandBusiness(string name)
        {
            this.Name = name;
            this.Models = new HashSet<ModelBusiness>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public ICollection<ModelBusiness> Models { get; set; }
    }
}
