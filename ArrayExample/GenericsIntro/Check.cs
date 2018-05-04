using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Check<DATATYPE>
    {
        //public bool Compare(int i, int y)
        //{
        //    if (i == y)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool Compare(DATATYPE i, DATATYPE y)
        {
            if (i.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
