using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Prod = new List<Product>()
        {
            new Product(){Name="PC", Price = 800},
            new Product(){Name = "Car", Price = 30000}



        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from {GetType().Name}.");
            return Prod;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a {GetType().Name}.\n");
        }
    }
}
