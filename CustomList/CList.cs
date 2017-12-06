using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CList <T>
    {
        T Input;
        int arrayLength;
        private int count;
        T[] array;

        void Add()
        {
          
        }
        void increaseArrayLength()
        {
            arrayLength++;
        }
        void setCount()
        {
            count = arrayLength;
        }


    }
}
