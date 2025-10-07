using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticWebAPI.Business.Entities
{
    public class ProductsEntity
    {
        public Int64 ID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Availablity { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }



    }
}
