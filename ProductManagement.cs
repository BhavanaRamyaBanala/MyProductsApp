using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProductApp
{
    public class ProductManagement
    {
        static SortedList<int, Products> Plist = new SortedList<int, Products>() {
            {1, new Products(){ Id=1,PName="SmartPhone",PPrice=29999.90,PBrand="Oppo",ManufacturingDate=new DateTime(2022,8,24),ExpiryDate=new DateTime(2024,8,16) } },
            {2, new Products(){ Id=2,PName="Headphones",PPrice=1999.60,PBrand="Boat",ManufacturingDate=new DateTime(2023,5,2),ExpiryDate=new DateTime(2025,4,23) } },
            {3, new Products() { Id=3,PName="Tablet",PPrice=29999.70,PBrand="HP",ManufacturingDate=new DateTime(2018,9,3),ExpiryDate=new DateTime(2021,8,14) }},
            {4, new Products() { Id=4,PName ="Speaker", PPrice = 5999.80, PBrand = "Boat", ManufacturingDate = new DateTime(2021, 2, 6), ExpiryDate = new DateTime(2023, 1, 17) } },
            {5, new Products() { Id=5,PName="Laptop",PPrice=79999.50,PBrand="Dell",ManufacturingDate=new DateTime(2015,8,5),ExpiryDate=new DateTime(2020,5,12) }},
            {6, new Products() { Id=6,PName="Soap",PPrice=299.20,PBrand="Santoor",ManufacturingDate=new DateTime(2016,1,2),ExpiryDate=new DateTime(2017,6,16) }}
            //{7, new Products() { Id=7,PName="Hair oil",PPrice=159.90,PBrand="Coconut",ManufacturingDate=new DateTime(2021,7,28),ExpiryDate=new DateTime(2023,6,13) }},
        };
        public SortedList<int, Products> allProducts()
        {
            return Plist;
        }
    }
}
