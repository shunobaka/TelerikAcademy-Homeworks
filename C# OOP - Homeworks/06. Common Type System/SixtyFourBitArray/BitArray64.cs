namespace SixtyFourBitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int index]
        {
            get
            {
                CheckIndex(index);
                return ((int)(this.number >> index) & 1);
            }
            set
            {
                CheckIndex(index);
                CheckValue(value);
                ModifyBit(value, index);
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 num = obj as BitArray64;
            return this.Number.Equals(num.Number);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public static bool operator !=(BitArray64 numOne, BitArray64 numTwo)
        {
            return !numOne.Equals(numTwo);
        }

        public static bool operator ==(BitArray64 numOne, BitArray64 numTwo)
        {
            return numOne.Equals(numTwo);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int index = 63; index >= 0; index--)
            {
                yield return this[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private static void CheckIndex(int index)
        {
            if (index < 0 || index >= 64)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private static void CheckValue(int value)
        {
            if (value != 0 && value != 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ModifyBit(int bit, int index)
        {
            if (bit == 1)
            {
                this.number |= (1ul << index);
            }
            else
            {
                this.number = ~(~number | (1ul << index));
            }
        }
    }
}
