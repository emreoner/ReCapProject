using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "DailyPrice should be bigger than 0")]
        public decimal DailyPrice { get; set; }

        [MinLength(2,ErrorMessage ="Car Name Should Be min 2 character long")]
        public string Description { get; set; }
      
    }
}
