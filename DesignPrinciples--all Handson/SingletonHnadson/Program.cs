using System;

namespace SingletonHnadson
{
    class Program
    {
        static void Main(string[] args)
        {
            DBCConn connection = DBCConn.GetInstance();
            connection.Name = "Sample Instance";

            var connection1 = DBCConn.GetInstance();

            //DBCConn connection2 = new DBCConn();

            Console.WriteLine($"Instance Name of connection 0 : {connection.Name} ");
            Console.WriteLine($"Instance Name of connection 1 : {connection1.Name} ");
            Console.Read();
        }
    }
}
