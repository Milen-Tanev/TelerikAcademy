namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        private List<byte> array = new List<byte>();

        public BitArray64 (ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }

            protected set
            {
                if (value < 0 || value > ulong.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The number cannot be less smaller than 0 or larger than {0}", ulong.MaxValue.ToString());
                }
                this.number = value;
            }
        }

        
        private List<byte> ConvertToBinary(ulong num)
        {
            ulong remainder;

            while (num > 0)
            {
                remainder = num % 2;
                num /= 2;
                this.array.Add((byte)remainder);
            }

            return this.array;
        }

        public byte GetIndexValue(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index cannot be negative number!");
            }
            List < byte > arr = ConvertToBinary(this.Number);
            if (index > arr.Count)
            {
                throw new ArgumentOutOfRangeException(string.Format("Index cannot be larger than {0}!", arr.Count));
            }
            return arr[index];
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(BitArray64 array1, BitArray64 array2)
        {
            return (array1.Equals(array2));
        }

        public static bool operator !=(BitArray64 array1, BitArray64 array2)
        {
            return !(array1.Equals(array2));

        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.ElementAt(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray64).Number);
        }
    }
}
