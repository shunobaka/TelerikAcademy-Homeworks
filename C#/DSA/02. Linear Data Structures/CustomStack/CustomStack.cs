namespace CustomStack
{
    public class CustomStack<T>
    {
        private T[] items;

        public CustomStack()
        {
            this.items = new T[4];
            this.Capacity = 4;
            this.TopIndex = -1;
        }

        private int TopIndex { get; set; }

        public int Capacity { get; private set; }

        public int Count
        {
            get
            {
                return this.TopIndex + 1;
            }
        }

        public void Push(T value)
        {
            if (TopIndex + 1 == this.Capacity)
            {
                this.ExtendArray();
            }

            this.TopIndex++;
            this.items[this.TopIndex] = value;
        }

        public T Pop()
        {
            this.TopIndex--;
            return this.items[TopIndex + 1];
        }

        private void ExtendArray()
        {
            T[] newItemsArray = new T[this.Capacity * 2];
            this.Capacity *= 2;

            for (int i = 0; i <= this.TopIndex; i++)
            {
                newItemsArray[i] = this.items[i];
            }

            this.items = newItemsArray;
        }
    }
}
