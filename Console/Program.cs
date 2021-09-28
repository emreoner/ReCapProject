using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCar();

            //TestBrand();

            //TestColor();
            // TestUser();

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success)
            //{
            //    foreach (var carDetail in result.Data)
            //    {
            //        System.Console.WriteLine($"{carDetail.CarName} - {carDetail.BrandName} - {carDetail.ColorName} - {carDetail.DailyPrice}");
            //        System.Console.WriteLine(result.Message);
            //    }
            //}
            //else
            //    System.Console.WriteLine(result.Message);
        }

        private static void TestUser()
        {
            var userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Emre", LastName = "ONER", Email = "emre@oner.com", Password = "pass" });

            System.Console.WriteLine(result.Message);

        }
        private static void TestColor()
        {
            var color = new Color
            {
                Id = 2,
                Name = "BLUE"
            };
            var colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(color);
        }

        private static void TestBrand()
        {
            var brand = new Brand
            {
                Id = 2,
                Name = "NISSAN"
            };

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(brand);
        }

        private static void TestCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var myCarObject = new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 400,
                Description = "HYBRID",
                ModelYear = 2020

            };

            ValidationContext validationContext = new ValidationContext(myCarObject);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(myCarObject, validationContext, validationResults, true);
            if (valid)
                carManager.Update(myCarObject);
            else
                foreach (ValidationResult validationResult in validationResults)
                    Debug.WriteLine(validationResult.ErrorMessage);
        }
    }
}
