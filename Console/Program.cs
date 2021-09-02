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
            CarManager carManager = new CarManager(new EfCarDal());
            var myCarObject = new Car
            {
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 400,
                Description = "ELECTRIC",
                ModelYear = 2021

            };
            ValidationContext validationContext = new ValidationContext(myCarObject);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(myCarObject, validationContext, validationResults, true);
            if (valid)
                carManager.Add(myCarObject);
            else
                foreach (ValidationResult validationResult in validationResults)
                    Debug.WriteLine(validationResult.ErrorMessage);











        }
    }
}
