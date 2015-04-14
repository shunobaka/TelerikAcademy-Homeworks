namespace GenericList
{
    using System;
    using System.Text;

    class GenericList<T>
        where T : IComparable<T>
    {
        private T[] list;
        private int elementCount;

        public GenericList(int size)
        {
            this.list = new T[size];
            this.elementCount = 0;
        }

        public void Add(T element)
        {
            if (this.elementCount == this.list.Length)
            {
                DoubleSize();
            }

            this.list[this.elementCount] = element;
            this.elementCount++;
        }

        public void RemoveAt(int index)
        {
            for (int i = index + 1; i <= this.elementCount; i++)
            {
                this.list[i - 1] = this.list[i];
            }
            this.list[this.elementCount] = default(T);
            this.elementCount--;
        }

        public void Insert(int index, T element)
        {
            if (this.elementCount == this.list.Length)
            {
                DoubleSize();
            }

            for (int i = this.elementCount; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = element;
            this.elementCount++;
        }

        public int IndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i < this.elementCount; i++)
            {
                if (this.list[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public T Min()
        {
            T result = default(T);

            if (this.elementCount > 0)
            {
                result = this.list[0];

                for (int i = 1; i < this.elementCount; i++)
                {
                    if (result.CompareTo(this.list[i]) > 0)
                    {
                        result = this.list[i];
                    }
                }
            }

            return result;
        }

        public T Max()
        {
            T result = default(T);

            if (this.elementCount > 0)
            {
                result = this.list[0];

                for (int i = 1; i < this.elementCount; i++)
                {
                    if (result.CompareTo(this.list[i]) < 0)
                    {
                        result = this.list[i];
                    }
                }
            }

            return result;
        }

        private void DoubleSize()
        {
            T[] newList = new T[this.list.Length * 2];

            for (int i = 0; i < this.list.Length; i++)
            {
                newList[i] = this.list[i];
            }

            this.list = newList;
        }

        public void Clear()
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                this.list[i] = default(T);
            }
            this.elementCount = 0;
        }

        public T this[int index]
        {
            get
            {
                if (ValidIndex(index))
                {
                    return this.list[index];
                }
                else
                {
                    return default(T);
                }
            }
            set
            {
                if (ValidIndex(index))
                {
                    this.list[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private bool ValidIndex(int index)
        {
            if (index >= 0 && index < elementCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();

            for (int i = 0; i < this.elementCount; i++)
			{
                content.AppendLine(String.Format("[{0}] {1}", i, this.list[i]));
			}

            return content.ToString();
        }
    }
}
