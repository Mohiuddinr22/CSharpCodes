using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1__13_02_2023_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDate manufactureDate1 = new CustomDate(10,02,2022);
            
            Product Television = new Product(8899, "Samsung Series 22", manufactureDate1, 5599.99);
            
            Console.WriteLine("{0} details : ", Television.GetName());
            Television.ShowProductDetails();

            //---------------------------------------------------------//

            CustomDate manufactureDate2 = new CustomDate(16, 6, 2021);
            
            Product Refrigerator = new Product();
            Refrigerator.SetId(1118);
            Refrigerator.SetName("Shark XX88");
            Refrigerator.SetManufactureDate(manufactureDate2);
            Refrigerator.SetPrice(999.899);
            
            Console.WriteLine("{0} details : ", Refrigerator.GetName());
            Refrigerator.ShowProductDetails();
        }
    }
}
