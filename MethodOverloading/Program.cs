using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {

        static void Main(string[] args)
        {
            int answer1 = Add(5, 5);
            Console.WriteLine(answer1);

            decimal answer2 = Add(65.23m, 542.1m);
            Console.WriteLine(answer2);

            string answer3 = Add(1, 0, true);
            Console.WriteLine(answer3);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        static decimal Add(decimal num1, decimal num2) 
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool isMoney)
        {
            int sum = num1 + num2;

            if (isMoney == true && sum > 1) 
            {
                return $"{sum} dollars";
            
            }

            else if (isMoney == true && sum >= 1) 
            {

                return $"{sum} dollar";
            }

            else 
            {

                return $"{sum}";
            }
            
        }


    }
}
