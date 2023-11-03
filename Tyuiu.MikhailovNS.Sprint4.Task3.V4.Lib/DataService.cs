using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MikhailovNS.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            int res= array[0,columns-1];            

            for (int i = 0; i<rows; i++)
            {
                if(array[i, columns-1] <res)
                {
                    res = array[i, columns-1];
                }    
            }
            return res;
        }
    }
}
