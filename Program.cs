using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Calculations
    {
        public double Calc(double p)
        {
            double Side = p / 3;
            double s = Math.Sqrt( 0.5 * p * Math.Pow((0.5 * p - Side), 3));
            return s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double TrPer = default(double);
            Console.WriteLine("Enter triangle perimeter:");
            string temp = Console.ReadLine();
            TrPer = Convert.ToDouble(temp);
            var a = new Calculations();
            double SqResult = a.Calc(TrPer);
            double SideResult = TrPer/3;
            Console.WriteLine("{0:F2}", "Side | Square \n" +
            SideResult + "|" + SqResult);
            //Console.WriteLine("{0:F2}", SideResult);
            //Console.WriteLine("{0:F2}", SqResult);
            Console.ReadLine();
        }
    }
}
