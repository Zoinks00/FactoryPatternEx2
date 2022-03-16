using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)

        {
            //switch statement to select database from user input 
            switch(databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
            }
        }

    }
}
