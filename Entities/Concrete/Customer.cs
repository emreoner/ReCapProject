using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
