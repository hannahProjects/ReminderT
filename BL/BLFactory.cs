using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BL
{
    public class BLFactory
    {
        static public BL_Imp myIBL= null;
        static public BL_Imp getBL(Action<object, EventArgs> d)
        {
            if (myIBL == null)
                myIBL = new BL_Imp(d);
            return myIBL;
        }
        public static BL_Imp getBL()
        {
            return myIBL;
        }
    }
}
