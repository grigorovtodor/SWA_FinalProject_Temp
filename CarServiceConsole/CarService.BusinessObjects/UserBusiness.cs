namespace CarService.BusinessObjects
{
    using EnumsBusiness;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class UserBusiness
    {
        private string name;
        private long idCardNumber;
        private string uniqueIdNumber;
        private string phoneNumber;
        private GenderBusiness gender;
        private string email;
        private string address;

        public UserBusiness(string name, long idCardNumber, string uniqueIdNumber, string phoneNumber, GenderBusiness gender) : this(name, idCardNumber, uniqueIdNumber, phoneNumber, null, null, gender)
        {

        }

        public UserBusiness(string name, long idCardNumber, string uniqueIdNumber,  string phoneNumber, string email, string address, GenderBusiness gender)
        {
            this.Name = name;
            this.IdCardNumber = idCardNumber;
            this.UniqueIdNumber = uniqueIdNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
            this.Gender = gender;
            this.Cars = new HashSet<CarBusiness>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public long IdCardNumber { get; set; }

        public string UniqueIdNumber { get; set; }

        public string Address { get; set; }

        public GenderBusiness Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool isDeleted { get; set; }

        public ICollection<CarBusiness> Cars { get; set; }
    }
}
