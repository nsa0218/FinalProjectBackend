using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string ContactName { get; set; }

    }
}
