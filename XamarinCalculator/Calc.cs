using System;
namespace XamarinCalculator
{
    public class Calc
    {
        public static double Calulate(double a, double b, string op)
        {

            double res;

            switch(op)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    if (!b.Equals(0))
                    res = a / b;
                    res = 0;
                    break;
                default:
                    return 0;
            }

            return res;
        }
    }
}
