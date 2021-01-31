using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Category:IEntity 
    {
        public int CarCategoryId { get; set; }
        public string CarCategoryName { get; set; }

    }
}
