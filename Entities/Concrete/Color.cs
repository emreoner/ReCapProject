﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
