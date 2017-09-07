using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square
    {
        int square = 2;
        public Square(int size)
        {
            arr = new int[size];
        }

        int[] arr;
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {

                double a= Math.Pow(value ,square );

                arr[index] = (int)a;
                
            }
        }
    }
}
