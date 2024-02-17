using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProductApp
{
    public class Products
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
