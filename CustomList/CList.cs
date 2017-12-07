﻿using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    public class CList <T> : IEnumerable
    {
        T[] cArray;
        T[] newCArray;
        int capacity = 1;
        int count = 0;
        public CList()
        {
            this.cArray = new T[capacity];

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cArray[i];
            }
        }
        //public IEnumerable GetEnumerator()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        yield return cArray[i];
        //    }
        //}
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
        public void Remove(T input)
        {
            bool inputPresent = false;
            int counter = count;
            T[] removedArray = new T[capacity];
            for (int i = 0; i < counter; i++)
            {
                if (cArray[i].Equals(input) && !inputPresent)
                {
                    inputPresent = true;
                    DecreaseCount();
                    DecreaseCapacity();
                    continue;
                }
                if (inputPresent)
                {
                    removedArray[i-1] = cArray[i];
                }
                else
                {
                    removedArray[i] = cArray[i];
                }
            }
            if (inputPresent)
            {
                SetNewArray();
                for (int i = 0; i < count; i++)
                {
                    newCArray[i] = removedArray[i];
                }
                cArray = newCArray;
            }

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
        int DecreaseCapacity()
        {
            capacity--;
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
        int DecreaseCount()
        {
            count--;
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
        public override string ToString()
        {
            string returnString = "";
            foreach(T input in this)
            {
                returnString += input.ToString();
            }
            return returnString;
        }
        public static CList<T> operator +(CList<T> firstList,CList <T> secondList)
        {
            CList<T> CombinedList = new CList<T>();
            for (int i = 0; i < firstList.count; i++)
            {
                for (int j = firstList.count + 1; j < secondList.count; j++)
                {
                    CombinedList[i] = firstList[i];
                    CombinedList[j] = secondList[i];
                }
            }
            return new CList<T>();
        }
        public void Join (CList<T> firstList, CList<T> secondList)
        {
            int combinedListCapacity = (firstList.capacity + secondList.capacity);
            int combinedListCount = (firstList.count + secondList.count);
            T[] CombinedList = new T[combinedListCapacity];
            for (int i = 0; i<firstList.count; i++)
            {
                    CombinedList[i] = firstList[i];
                    CombinedList[i + firstList.count] = secondList[i];
            }
            cArray = CombinedList;
        }


    }
}
