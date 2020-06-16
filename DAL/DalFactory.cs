using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DalFactory
    {

        static public Idal myDal = null;
        static public Idal getDal()
        {
            if (myDal == null)
                myDal = new Dal_Imp();
            return myDal;
        }
    }
}
