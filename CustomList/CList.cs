using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CList<T>
    {
        T[] cArray;
        T[] newCArray;
        private int capacity = 5;
        private int count = 0;
        public CList()
        {
            this.cArray = new T[capacity];
        }
        public void Add(T input)
        {
            CheckCountOverCapacity();
            AddNewInput(input);
            IncreaseCount();
        }
        T[] AddNewInput(T input)
        {
            cArray[count] = input;
            return cArray;
        }
        int AddCapacity()
        {
            capacity++;
            return capacity;
        }
        void CheckCountOverCapacity()
        {
            if (count >= (capacity / 2))
            {
                AddCapacity();
                SetNewArray();
            }
        }
        T[] SetNewArrayCapacity()
        {
            newCArray = new T[capacity];
            return newCArray;
        }
        int IncreaseCount()
        {
            count++;
            return count;
        }
        T[] SetNewArray()
        {
            SetNewArrayCapacity();
            for (int i = 0; i <= count; i++)
            {
                newCArray[i] = cArray[i];
            }
            cArray = newCArray;
            return cArray;
        }
        public T this[int index]
        {
            get
            {
                return cArray[index];
            }
            set
            {
                cArray[index] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
