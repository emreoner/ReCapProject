using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentalDal : EfEntityRepositoryBase<Rental, RecapDBContext>, IRentalDal
    {
        public bool CheckIfCarIsAvailable(long carId)
        {
            using (RecapDBContext context=new RecapDBContext())
            {
                return (!context.Set<Rental>().Any(r => r.CarId == carId && r.ReturnDate == null));
            }
        }
    }
}
