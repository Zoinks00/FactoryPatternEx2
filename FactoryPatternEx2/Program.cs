using System;


namespace FactoryPatternEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of database would you like to use?");
            Console.WriteLine("Options are: List, SQL, Mongo");
            Console.WriteLine("Enter an Option now.");
            //varible to hold user input
            string input = Console.ReadLine();

            //setup interface to call class with switch method
            IDataAccess choice = DataAccessFactory.GetDataAccessType(input);

           var prod = choice.LoadData();
            choice.SaveData();


            foreach(var item in prod)
            {
                Console.WriteLine($"Name = {item.Name} Price = {item.Price,0:c}");
            }
        }
    }
}
