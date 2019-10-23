using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello FooBarQix!");
            StartFooBarQix();
            Console.WriteLine("All done FooBarQix!");
            Console.ReadKey();
        }

        private static void StartFooBarQix()
        {
            for (int i = 1; i <= 10; i++)
            {
                var result = Compute(i.ToString());
                Console.WriteLine(result);
            }
        }

        public static string Compute(string input)
        {
            string strResult = String.Empty;
            int.TryParse(input, out var result);
            strResult = result.ToString();

            strResult = CheckNumberIsDivisibleBy(result, strResult);

            strResult = CheckNumberContains(result, strResult);

            return strResult;
        }

        private static string CheckNumberContains(int result, string strResult)
        {
            List<int> digits = new List<int>();
            while ((result % 10) > 0 || (result / 10 > 0))
            {
                digits.Add(result % 10);
                result = result / 10;
            }

            digits.Reverse();
            foreach (var digit in digits)
            {
                switch (digit)
                {
                    case 3:
                        strResult = StrResult(strResult, "Foo");
                        break;
                    case 5:
                        strResult = StrResult(strResult, "Bar");
                        break;
                    case 7:
                        strResult = StrResult(strResult, "Qix");
                        break;
                    case 0:
                        strResult = StrResult(strResult, "*");
                        //strResult1 += "*";
                        break;
                }
            }

            return strResult;
        }

        private static string CheckNumberIsDivisibleBy(int result, string strResult)
        {
            if (IsDivisibleBy(result, 3))
            {
                strResult = StrResult(strResult, "Foo");
            }

            if (IsDivisibleBy(result, 5))
            {
                strResult = StrResult(strResult, "Bar");
            }

            if (IsDivisibleBy(result, 7))
            {
                strResult = StrResult(strResult, "Qix");
            }

            return strResult;
        }

        private static string StrResult(string strResult, string replacement)
        {
            if (int.TryParse(strResult, out _))
            {
                strResult = replacement;
            }
            else
            {
                strResult += replacement;
            }

            return strResult;
        }

        private static bool IsDivisibleBy(int result, int denominator)
        {
            return (result % denominator == 0);
        }
    }
}
