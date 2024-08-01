using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Product
    {
        int pCode;
        public string pName;
        public int qtyInStock;
        int discountAllowed;
        static string brand;
        public int price;
        public int amount;
        public void GetDetails()
        {
            Console.WriteLine("enter pCode");
            pCode = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter pName");
            pName = Console.ReadLine();
            Console.WriteLine("enter qtyInStock");
            qtyInStock = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter discountAllowed");
            discountAllowed = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter price");
            price = Int16.Parse(Console.ReadLine());

        }
        static Product()
        {
            brand = "Lewis";
        }
        public void DisplayDetails()
        {
            Console.Write("pCode " + pCode);
            Console.Write("\tproduct name " + pName);
            Console.Write("\tqty in stock is " + qtyInStock);
            Console.Write("\tdicsount allowed " + discountAllowed);
            Console.Write("\tprice " + price);
            Console.WriteLine("amount " + amount);

        }
        public static void DisplayBrand()
        {
            Console.WriteLine("Brand is " + brand);
        }
    }
}