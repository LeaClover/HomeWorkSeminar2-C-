// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            if (str.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет!");
            }
            else
            {
                Console.WriteLine(str[2]);
            }
        }
       
    }
}