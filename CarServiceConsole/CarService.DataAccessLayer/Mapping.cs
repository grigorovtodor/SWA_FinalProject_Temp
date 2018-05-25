namespace CarService.DataAccessLayer
{
    using BusinessObjects;
    using Models;
    using System;
    using System.Collections.Generic;

    public static class Mapping
    {
        /// <summary>
        /// User mapping methods 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static UserBusiness ConvertToBusinessEntity(User user)
        {
            var businessObject = new UserBusiness(user.Name, user.IdCardNumber, user.UniqueIdNumber, user.PhoneNumber, user.Email, user.Address, (BusinessObjects.EnumsBusiness.GenderBusiness)(int)user.Gender);
            businessObject.Cars = (ICollection<CarBusiness>)user.Cars;
            

            return businessObject;
        }

        public static User ConvertToDataEntity(UserBusiness user)
        {
            var dataObject = new User(user.Name, user.IdCardNumber, user.UniqueIdNumber, user.PhoneNumber, user.Email, user.Address, (Models.Enums.Gender)(int)user.Gender);
            dataObject.Cars = (ICollection<Car>)user.Cars;

            return dataObject;
        }

        /// <summary>
        /// Car mapping methods
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public static CarBusiness ConvertToBusinessEntity(Car car)
        {
            var businessObject = new CarBusiness(ConvertToBusinessEntity(car.User), ConvertToBusinessEntity(car.Brand), ConvertToBusinessEntity(car.Model), car.VIN, car.RegistrationPlateNumber, (BusinessObjects.EnumsBusiness.ColorBusiness)car.Color);
            businessObject.RepairWorks = (ICollection<RepairWorkBusiness>)car.RepairWorks;

            return businessObject;
        }

        public static Car ConvertToDataEntity(CarBusiness car)
        {
            var dataObject = new Car(ConvertToDataEntity(car.User), ConvertToDataEntity(car.Brand), ConvertToDataEntity(car.Model), car.VIN, car.RegistrationPlateNumber, (Models.Enums.Color)car.Color);
            dataObject.RepairWorks = (ICollection<RepairWork>)car.RepairWorks;

            return dataObject;
        }

        /// <summary>
        /// Brand mapping methods
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        /// 
        public static BrandBusiness ConvertToBusinessEntity(Brand brand)
        {
            var businessObject = new BrandBusiness(brand.Name);
            businessObject.Models = (ICollection<ModelBusiness>)brand.Models;


            return businessObject;
        }

        public static Brand ConvertToDataEntity(BrandBusiness brand)
        {
            var dataObject = new Brand(brand.Name);
            dataObject.Models = (ICollection<Model>)brand.Models;

            return dataObject;
        }

        /// <summary>
        /// Model mapping methods
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static ModelBusiness ConvertToBusinessEntity(Model model)
        {
            var businessObject = new ModelBusiness(model.Name, ConvertToBusinessEntity(model.Brand));

            return businessObject;
        }

        public static Model ConvertToDataEntity(ModelBusiness model)
        {
            var dataObject = new Model(model.Name, ConvertToDataEntity(model.Brand));

            return dataObject;
        }

        /// <summary>
        /// RepairWork mapping methods
        /// </summary>
        /// <param name="repairWork"></param>
        /// <returns></returns>
        public static RepairWorkBusiness ConvertToBusinessEntity(RepairWork repairWork)
        {
            var businessObject = new RepairWorkBusiness(repairWork.RepairDate, repairWork.Description, repairWork.Price, ConvertToBusinessEntity(repairWork.Car));

            return businessObject;
        }

        public static RepairWork ConvertToBusinessEntity(RepairWorkBusiness repairWork)
        {
            var dataObject = new RepairWork(repairWork.RepairDate, repairWork.Description, repairWork.Price, ConvertToDataEntity(repairWork.Car));

            return dataObject;
        }
    }
}
