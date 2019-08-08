using System;

namespace StringCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator sc = new StringCalculator();
            string input = "//;,@,$$\n1;3;4@10$$1001";
            int output = sc.Add(input);

            Console.WriteLine($"The Sum is : '{output}'");
        }
    }
}
