using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity// sen veritabanı nesnesisin
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompaonyName { get; set; }
        public string City { get; set; }

    }
}
