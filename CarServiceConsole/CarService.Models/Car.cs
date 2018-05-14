namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        private ICollection<RepairWork> repairWorks;
        private Model model;

        public Car()
        {
            this.repairWorks = new List<RepairWork>();
        }

        [Key]
        public int Id { get; set; }

        public string VIN { get; set; }

        public string RegistrationPlateNumber { get; set; }

        public Color Color { get; set; }

        public Brand Brand { get; set; }

        public Model Model { get; set; } //this.model = new List<Model>().Select(m => m.BrandId = Brand.Id).ToList();

        public int UserId { get; set; }

        public User User { get; set; }

        public virtual ICollection<RepairWork> RepairWorks
        {
            get { return this.repairWorks; }
            set { this.repairWorks = value; }
        }
    }
}
