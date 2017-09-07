using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square
    {
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

                double a= Math.Pow(value , 2);

                arr[index] = (int)a;
                
            }
        }
    }
}
