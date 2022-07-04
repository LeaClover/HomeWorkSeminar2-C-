// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] {"1", "2", "3", "4", "5", "6", "7"};
            Console.WriteLine("Введите цифру дня недели и мы покажем является ли он выходным!");
            int number = Convert.ToInt32(Console.ReadLine());
            string num = Convert.ToString(number);
            if (number < str.Length+1)
            {
                if (num == str[5] ^ num == str[6])
                    {
                      Console.WriteLine("Ура! Это выходной!");
                    }
                else
                    {
                      Console.WriteLine("Не выходной :с");
                    }
            }
            else
            {
                Console.WriteLine("Неверное значение!!!");
            }
        
        }
       
    }
}