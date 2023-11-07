﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MikhailovNS.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int res=0;

            for(int i = 0; i<rows;i++)
            {
                for(int j = 0; j < columns;j++)
                    {
                        if(matrix[i,j]<0)
                        {
                        res++;
                        }
                    }
            }
            return res;
        }
    }
}