using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_module08
{
    class RangeOfArray
    {
        public int _start;
        public int _end;
        public int[] _arr;
        public RangeOfArray(int end, int start)
        {
            _start = start;
            _end = end;
            _arr = new int[Math.Abs(_end - _start) + 1];
        }
        public void Print(RangeOfArray arr, int start)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine($"{i + start} элемент массива равен = " + _arr[i]);
            }
        }
    }
}
