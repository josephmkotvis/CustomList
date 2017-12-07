namespace CustomList
{
    public class CList<T>
    {
        T[] cArray;
        T[] newCArray;
        int inputCount;
        int specificIndex;
        private int capacity = 1;
        private int count = 0;
        public CList()
        {
            this.cArray = new T[capacity];
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
