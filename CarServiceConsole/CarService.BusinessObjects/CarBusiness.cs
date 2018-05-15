namespace CarService.BusinessObjects
{
    using EnumsBusiness;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CarBusiness
    {
        private UserBusiness user;
        private BrandBusiness brand;
        private ModelBusiness model;
        private string vin;
        private string registrationPlateNumber;
        private ColorBusiness color;

        public CarBusiness(UserBusiness user, BrandBusiness brand, ModelBusiness model, string vin, string registrationPlateNumber, ColorBusiness color)
        {
            this.User = user;
            this.Brand = brand;
            this.Model = model;
            this.VIN = vin;
            this.RegistrationPlateNumber = registrationPlateNumber;
            this.Color = color;
            this.RepairWorks = new List<RepairWorkBusiness>();
        }

        public int Id { get; set; }

        public string VIN { get; set; }

        public string RegistrationPlateNumber { get; set; }

        public ColorBusiness Color { get; set; }

        public BrandBusiness Brand { get; set; }

        public ModelBusiness Model { get; set; } //this.model = new List<Model>().Select(m => m.BrandId = Brand.Id).ToList();

        public UserBusiness User { get; set; }

        public bool isDeleted { get; set; }

        public ICollection<RepairWorkBusiness> RepairWorks { get; set; }
    }
}
