using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product("P101", "Sports shoe", 1599.00, 25);
            Product productTwo = new Product("P102", "Denim shirt", 1500.99, 50);
            Product productThree = new Product("P103", "Laptop bag", 1400.93, 10);

            Product[] productArray = new Product[3];

            productArray[0] = productOne;
            productArray[1] = productTwo;
            productArray[2] = productThree;

            Console.WriteLine("ProductID\tProductName\tPrice\t\tQuantityAvailable");
            Console.WriteLine("-----------------------------------------------------------------");

            for (int i = 0; i < productArray.Length; i++)
            {
                Console.WriteLine("{0, -10}\t{1}\t{2}\t\t{3}",
                    productArray[i].ProductId,
                    productArray[i].ProductName,
                    productArray[i].Price,
                    productArray[i].QuantityAvailable
                    );
            }

            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
