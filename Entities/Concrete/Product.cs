using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product: IEntity
    {
        public int CarId { get; set; }
        public string CarBrantId { get; set; }
        public int ColorId { get; set; }
        public string CarModelYear { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string CarDescription { get; set; }


    }
}
