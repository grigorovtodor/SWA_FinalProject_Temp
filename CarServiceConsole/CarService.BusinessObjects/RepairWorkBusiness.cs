namespace CarService.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RepairWorkBusiness
    {
        private DateTime repairDate;
        private string description;
        private decimal price;
        private CarBusiness car;

        public RepairWorkBusiness(DateTime repairDate, string description, decimal price, CarBusiness car)
        {
            this.RepairDate = repairDate;
            this.Description = description;
            this.Price = price;
            this.Car = car;
        }

        public int Id { get; set; }

        public DateTime RepairDate { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public CarBusiness Car { get; set; }

    }
}
