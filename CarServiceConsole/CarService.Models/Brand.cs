namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Brand
    {
        private ICollection<Model> models;

        public Brand()
        {
            this.models = new HashSet<Model>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public int ModelId { get; set; }

        public bool isDeleted { get; set; }

        public virtual ICollection<Model> Models
        {
            get { return this.models; }
            set { this.models = value; }
        }
    }
}
