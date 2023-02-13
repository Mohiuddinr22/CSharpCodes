using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1__13_02_2023_
{
    struct CustomDate 
    {
        public byte day;
        public byte month;
        public ushort year;

        public CustomDate(byte day, byte month, ushort year)
        {
                this.day = day;
                this.month = month;
                this.year = year;
        }

        public void ShowDate()
        {
            Console.WriteLine("{0}/{1}/{2}",this.day,this.month,this.year);
        }

    }
    class Product
    {
        private uint id;
        private string name;
        private CustomDate manufactureDate;
        private double price;

        public uint GetId()
        {
            return this.id;
        }
        public string GetName() 
        {
            return this.name;
        }
        public double GetPrice() 
        {
            return this.price;  
        }
        public CustomDate GetManufactureDate() 
        {
            return this.manufactureDate;
        }

        public void SetId(uint id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetManufactureDate(CustomDate manufactureDate)
        {
            this.manufactureDate = manufactureDate;
        }
        public void SetPrice(double price) 
        {
            this.price = price;
        }
        public Product(){}

        public Product(uint id, string name, CustomDate manufactureDate, double price)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetManufactureDate(manufactureDate);
            this.SetPrice(price);
        }
        public void ShowProductDetails()
        {
            Console.WriteLine("ID               : {0}", this.GetId());
            Console.WriteLine("Name             : {0}", this.GetName());
            Console.Write    ("Manufacture Date : ");
            this.GetManufactureDate().ShowDate();
            Console.WriteLine("Price            : ${0}", this.GetPrice());
            Console.WriteLine();
        }
    }

}
