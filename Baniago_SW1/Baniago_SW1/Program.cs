namespace Baniago_SW1
{
    using System;

    class Program
    {
        // check if a number is prime
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // convert dollars to peso and yen
        static (double, double) ConvertCurrency(double dollar)
        {
            double pesoRate = 57.17;
            double yenRate = 146.67;

            double peso = dollar * pesoRate;
            double yen = dollar * yenRate;

            return (peso, yen);
        }

        static void Main(string[] args)
        {
            // Prime or Composite
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int count = 1;
            foreach (string n in numbers)
            {
                int num = int.Parse(n);
                bool prime = IsPrime(num);

                if (prime)
                {
                    Console.WriteLine(count + ". " + num + "\tPrime");
                }
                else
                {
                    Console.WriteLine(count + ". " + num + "\tComposite");
                }
                count++;
            }

            // money converter
            Console.Write("\nEnter currency in ($): ");
            string currencyInput = Console.ReadLine();
            string[] dollarParts = currencyInput.Split(',');

            Console.WriteLine("\nDollar($)\tPeso(P)\t\tYen(Y)");

            foreach (string part in dollarParts)
            {
                double dollar = double.Parse(part);
                var result = ConvertCurrency(dollar);
                double peso = result.Item1;
                double yen = result.Item2;

                Console.WriteLine(dollar + "\t\t" + peso.ToString("F2") + "\t" + yen.ToString("F2"));
            }
        }
    }
}