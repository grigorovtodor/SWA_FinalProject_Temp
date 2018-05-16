namespace CarService.Models
{
    using Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        //private string name;
        //private long idCardNumber;
        //private string uniqueIdNumber;
        //private string phoneNumber;
        //private Gender gender;
        //private string email;
        //private string address;

        private ICollection<Car> cars;

        public User(string name, long idCardNumber, string uniqueIdNumber, string phoneNumber, Gender gender) : this(name, idCardNumber, uniqueIdNumber, phoneNumber, null, null, gender)
        {

        }

        public User(string name, long idCardNumber, string uniqueIdNumber, string phoneNumber, string email, string address, Gender gender)
        {
            this.Name = name;
            this.IdCardNumber = idCardNumber;
            this.UniqueIdNumber = uniqueIdNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
            this.Gender = gender;
            this.cars = new HashSet<Car>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        public long IdCardNumber { get; set; }

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
