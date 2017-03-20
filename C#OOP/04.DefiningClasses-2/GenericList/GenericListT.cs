using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericListT<T>
    {
        private int count = 0;
        private int capacity;

        public GenericList(int count)
        {

        }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                this.count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {

            }
        }

    }
}
