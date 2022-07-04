// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число и мы покажем вам вторую цифру этого числа!");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            if (str.Length == 3)
            {
                Console.WriteLine(str[1]);
            }
            else
            {
                Console.WriteLine("Введенное число не является трехзначным!");
            }
        }
       
    }
}