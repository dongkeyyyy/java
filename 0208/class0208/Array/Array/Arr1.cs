using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Arr1
    {
        private int hap;
        private int avg;
        int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        public Arr1(int hap, int avg)
        {
            this.hap = hap;
            this.avg = avg;
        }

        public int Hap
        {
            get { return hap; }
            set { hap = value; }
        }

        public int Avg
        {
            get { return avg; }
            set { avg = value; }
        }
    }
}
