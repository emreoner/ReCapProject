using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public long Id { get; set; }
        public long BrandId { get; set; }
        public long ColorId { get; set; }
        public long ModelYear { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "DailyPrice should be bigger than 0")]
        public decimal DailyPrice { get; set; }

        [MinLength(2,ErrorMessage ="Car Name Should Be min 2 character long")]
        public string Description { get; set; }
      
    }
}
