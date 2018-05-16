namespace CarService.Models
{
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        private ICollection<RepairWork> repairWorks;
        //private Model model;

        public Car(User user, Brand brand, Model model, string vin, string registrationPlateNumber, Color color)
        {
            this.User = user;
            this.Brand = brand;
            this.Model = model;
            this.VIN = vin;
            this.RegistrationPlateNumber = registrationPlateNumber;
            this.Color = color;
            this.repairWorks = new List<RepairWork>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(17)]
        [MinLength(17)]
        public string VIN { get; set; }

        [MaxLength(8)]
        public string RegistrationPlateNumber { get; set; }

        public Color Color { get; set; }

        public Brand Brand { get; set; }

        public Model Model { get; set; } 

        public int UserId { get; set; }

        public User User { get; set; }

        public bool isDeleted { get; set; }

        public virtual ICollection<RepairWork> RepairWorks
        {
            get { return this.repairWorks; }
            set { this.repairWorks = value; }
        }
    }
}
