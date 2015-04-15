﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static void Swap(ref int x, ref int y)
        {
            if (x <= 0 || y <= 0) throw new ArgumentOutOfRangeException();
            int temp = x;
            x = y;
            y = temp;
        }

    }
}
