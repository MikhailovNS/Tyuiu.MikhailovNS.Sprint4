﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MikhailovNS.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int y = 1;
            for(int i = 0;i<=array.Length-1; i++ )
            {
                if(array[i] % 2 == 0)
                {
                    y *= array[i];
                }
            }
            return y;
        }
    }
}
