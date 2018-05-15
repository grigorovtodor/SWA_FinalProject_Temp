namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
