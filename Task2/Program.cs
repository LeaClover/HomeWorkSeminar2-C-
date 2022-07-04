// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно 
// числу первому, то программа выводит остаток от деления. 
 
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if(number1%number2==0)
            {
                
                Console.WriteLine($"Кратно, остатка нет");
            }
            else
            {
                int Bal = number1%number2;
                Console.WriteLine($"Не кратно, остаток {Bal}");
            }
            
        }

    }
}