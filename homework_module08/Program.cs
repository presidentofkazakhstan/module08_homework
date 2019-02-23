using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_module08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало диапазона массива");
            int lowerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона массива");
            int upperIndex = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (!(lowerIndex > upperIndex))
            {
                Console.WriteLine("Нижний индекс равен " + lowerIndex + " верхний индекс равен " + upperIndex);

                RangeOfArray array = new RangeOfArray(upperIndex, lowerIndex);
                for (int i = 0; i < array._arr.Length; i++)
                {
                    array._arr[i] = lowerIndex;
                }
                array.Print(array, lowerIndex);
            }
            else
            {
                Console.WriteLine("Введены некорректные индексы");
            }
            Console.Read();
        }
    }
}
