// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа. 
 
// 456 -> 46 
 
// 782 -> 72 
 
// 918 -> 98 

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(GetRandomNumber());
            Console.WriteLine(str);
            Console.WriteLine($"{str[0]}{str[2]}");
        }
        public static int GetRandomNumber()
        {
            int number = new Random().Next(100, 1000);
            return number;
        }
    }
}