using System;

namespace WhileAndDoWhileLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // While döngüsü ile sayı sayma
            Console.WriteLine("Counting from 1 to 5 using while loop:");
            int count = 1;
            while (count <= 5)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();

            // Do-while döngüsü ile kullanıcıdan geçerli bir sayı alana kadar tekrar etme
            int number;
            do
            {
                Console.Write("Enter a positive number: ");
                number = int.Parse(Console.ReadLine());
            }
            while (number <= 0);

            Console.WriteLine("You entered a positive number: " + number);

            // While döngüsü ile basit bir toplam işlemi
            int sum = 0;
            int i = 1;
            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum of numbers from 1 to 5 is: " + sum);

            // Do-while döngüsü ile bir metni en az bir kez yazdırma
            string message = "Hello, World!";
            int repeatCount = 3;
            int j = 0;

            Console.WriteLine("Printing message using do-while loop:");
            do
            {
                Console.WriteLine(message);
                j++;
            }
            while (j < repeatCount);
        }
    }
}