using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    class DBFactory
    {
       
            static public TaskContext myDb = null;
            static public TaskContext getDB()
            {
                if (myDb == null)
                    myDb = new TaskContext();
                return myDb;
            }

        
    }
}

