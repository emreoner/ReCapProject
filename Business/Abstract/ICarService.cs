using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(long brandId);

        IDataResult<List<Car>> GetCarsByColorId(long colorId);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
