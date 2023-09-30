using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShananinaVV.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double res = Math.Round(2 * (Math.Cos(3 * x) / Math.Sin(3 * x)) - (Math.Log(Math.Cos(x)) / (Math.Log(1 + Math.Pow(x, 2)))),3);
            return res;

        }
    }
}