using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Searcher
    {
        private List<int> arr;
        private int searchedItem;

        public Searcher(List<int> array, int searchedItem)
        {
            this.SearchedItem = searchedItem;
            this.Arr = array;
        }

        public List<int> Arr
        {
            get
            {
                return this.arr;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The array cannot be null!");
                }

                this.arr = value;
            }
        }

        public int SearchedItem { get; set; }

        public int Search()
        {
            this.Arr.Sort();

            int result = this.findItem(this.Arr, this.SearchedItem);

            if (result == -1)
            {
                throw new ArgumentException("Item not found");
            }
            return result;
        }

        protected abstract int findItem(List<int> arr, int item);
    }
}
