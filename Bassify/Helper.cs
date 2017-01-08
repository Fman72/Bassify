using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassify
{
    class Helper
    {
        public static List<char> initializeSizedList(int size)
        {
            char[] sizedArray = new char[size];
            List<char> sizedList = new List<char>(sizedArray);
            return sizedList;
        }
    }
}
