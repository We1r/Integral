using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace Вычисление_определенного_интеграла
{
    internal class Fuction
    {
        string functionString;

        public Fuction(string functionString)
        {
            this.functionString = functionString;
        }
        public double StandartFunction(double x)
        {
            string func = "f(x) = " + functionString;
            Function function = new Function(func);
            double Result = function.calculate(x);
            return Result;
        }
        public double MinusFunction(double x)
        {
            string func = "f(x) = (" + functionString + ") * -1.0";
            Function function = new Function(func);
            double Result = function.calculate(x);
            return Result;
        }
        public double AbsFunction(double x)
        {
            string func = "f(x) = abs(" + functionString + ")";
            Function function = new Function(func);
            double Result = function.calculate(x);
            return Result;
        }
        public double DerivFunction(double x)
        {
            string xs = x.ToString();
            Expression ex = new Expression("der(" + functionString + ", x, " + xs.Replace(',', '.') + ")");
            return ex.calculate();
        }
    }
}
