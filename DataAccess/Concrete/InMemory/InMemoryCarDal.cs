using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1,BrandId=1,ColorId=1,DailyPrice=300,Description="TOGG", ModelYear=2021},
                 new Car{ Id=2,BrandId=2,ColorId=1,DailyPrice=200,Description="BMC", ModelYear=2020},
                  new Car{ Id=3,BrandId=2,ColorId=1,DailyPrice=400,Description="TOFAS", ModelYear=2021},
                   new Car{ Id=4,BrandId=3,ColorId=1,DailyPrice=100,Description="ANADOL", ModelYear=2019}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));
        }

  
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var objectToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            objectToUpdate.BrandId = car.BrandId;
            objectToUpdate.ColorId = car.ColorId;
            objectToUpdate.DailyPrice = car.DailyPrice;
            objectToUpdate.Description = car.Description;
            objectToUpdate.ModelYear = car.ModelYear;
        }
    }
}
