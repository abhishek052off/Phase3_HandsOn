using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonHnadson
{
    class DBCConn
    {
        private static DBCConn _instance;
        public String Name { get; set; }

        private DBCConn() { }
        
          public static DBCConn GetInstance()
            {

                if (_instance == null)
                 {
                        _instance = new DBCConn(); 
                 }
                    


                return _instance;
            }
        
    }
}
