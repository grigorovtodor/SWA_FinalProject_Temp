namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        private ICollection<Car> cars;

        public User()
        {
            this.cars = new HashSet<Car>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        public long IdNumber { get; set; }

        [MaxLength(10)]
        public string UniqueIdNumber { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool isDeleted { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
