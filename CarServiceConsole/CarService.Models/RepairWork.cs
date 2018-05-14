namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RepairWork
    {
        [Key]
        public int Id { get; set; }

        public DateTime RepairDate { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        //test
    }
}
