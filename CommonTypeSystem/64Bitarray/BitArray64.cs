/* Problem 5. 64 Bit array
Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */
namespace Bitarray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private const int LENGTH = 64;

        private int lengthNum;

        public BitArray64(ulong number)
        {
            this.Number = number;
            this.lengthNum = number.ToString().Length;
        }

        public ulong Number { get; set; }

        public int this[int ind]
        {
            get
            {
                if (ind < 0 || ind >= LENGTH)
                {
                    throw new IndexOutOfRangeException("No such position.");
                }

                return (int)(this.Number >> ind) & 1;
            }

            set
            {
                if (ind < 0 || ind >= LENGTH)
                {
                    throw new IndexOutOfRangeException("No such position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("The value is not valid.");
                }

                if (value == 1)
                {
                    this.Number = this.Number | ((ulong)1 << ind);
                }
                else if (value == 0)
                {
                    this.Number = this.Number & (~((ulong)1 << ind));
                }
            }
        }

        public static bool operator ==(BitArray64 num1, BitArray64 num2)
        {
            return BitArray64.Equals(num1, num2);
        }

        public static bool operator !=(BitArray64 num1, BitArray64 num2)
        {
            return !BitArray64.Equals(num1, num2);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < LENGTH; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object num)
        {
            return this.Number.Equals((num as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return LENGTH.GetHashCode() ^ this.Number.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this);
        }
    }
}
