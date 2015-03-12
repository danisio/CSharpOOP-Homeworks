namespace Generic
{
    using System;
    using System.Text;

    public class GenericList<T>
        where T : IComparable
    {
        private T[] elements;
        private int count = 0;

        public GenericList(int size)
        {
            this.elements = new T[size];
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
            }
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                T result = this.elements[index];
                return result;
            }
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.ResizeData();
            }

            this.elements[this.Count] = element;
            this.count++;
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Count == this.Capacity)
            {
                this.ResizeData();
            }

            for (int i = this.Count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Capacity)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index + 1; i < this.Count; i++)
            {
                this.elements[i - 1] = this.elements[i];
            }

            this.elements[this.Count - 1] = default(T);
            this.count--;
        }

        public void Clear()
        {
            this.elements = new T[this.Capacity];
            this.count = 0;
        }

        public int IndexOf(T element)
        {
            return Array.IndexOf(this.elements, element);
        }

        public T Min()
        {
             T result = default(T);

             if (this.Count > 0)
             {
                 result = this.elements[0];

                 for (int i = 1; i < this.Count; i++)
                 {
                     if (result.CompareTo(this.elements[i]) > 0)
                     {
                         result = this.elements[i];
                     }
                 }
             }

            return result;
        }

        public T Max()
        {
            T result = default(T);

            if (this.Count > 0)
            {
                result = this.elements[0];

                for (int i = 1; i < this.Count; i++)
                {
                    if (result.CompareTo(this.elements[i]) < 0)
                    {
                        result = this.elements[i];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.AppendFormat("Element {0} --> {1}\n", i, this.elements[i].ToString());
            }

            return result.ToString();
        }

        private void ResizeData()
        {
            int newSize = this.elements.Length * 2;
            T[] newArray = new T[newSize];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
        }
    }
}