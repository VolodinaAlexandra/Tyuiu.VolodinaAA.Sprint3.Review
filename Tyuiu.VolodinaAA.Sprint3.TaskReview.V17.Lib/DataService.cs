using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.VolodinaAA.Sprint3.TaskReview.V17.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x)/(x+1.7)-Math.Cos(x) * 4 *x - 6, 2);
                valueArray[count] = y;
                count++;
                if ((x+1.7) == 0)
                {
                    Console.WriteLine(0);
                }  
            }
            return valueArray;
        }
    }
}
