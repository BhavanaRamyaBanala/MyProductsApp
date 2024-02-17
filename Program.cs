// See https://aka.ms/new-console-template for more information

using MyProductApp;

Console.WriteLine("** All Products **");
ProductManagement pm = new ProductManagement();
foreach (var p in pm.allProducts())
{
    Console.WriteLine($"Id:{p.Key}");
    Console.WriteLine($"PName:{p.Value.PName}");
    Console.WriteLine($"PPrice:{p.Value.PPrice}");
    Console.WriteLine($"PBrand:{p.Value.PBrand}");
    Console.WriteLine($"ManufacturingDate:{p.Value.ManufacturingDate}");
    Console.WriteLine($"ExpiryDate:{p.Value.ExpiryDate}");
    Console.WriteLine("--------------------------------");
}