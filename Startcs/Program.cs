using System.Globalization;

namespace Startcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание №1
            //Console.WriteLine("Введите число от 1 до 100:");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 1 || number > 100)
            //{
            //    Console.WriteLine("Ошибка: число не входит в диапазон.");
            //}
            //else
            //{
            //    if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // Задание №2
            //Console.WriteLine("Введите число:");
            //double number = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите процент:");
            //double percent = double.Parse(Console.ReadLine());

            //double result = (number * percent) / 100;
            //Console.WriteLine($"{percent}% от {number} = {result}");

            // Задание №3
            //Console.WriteLine("Введите четыре цифры:");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());

            //int number = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
            //Console.WriteLine($"Result: {number}");

            // Задание №4
            //Console.WriteLine("Enter number:");
            //string number = Console.ReadLine();

            //if (number.Length != 6)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{            
            //    char[] num = number.ToCharArray();
            //    char temp = num[0];
            //    num[0] = num[5];
            //    num[5] = temp;
            //    Console.WriteLine($"Result: {new string(num)}");
            //}

            // Задание №5
            //Console.WriteLine("Input date(dd.mm.yyyy):");
            //DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            //string season = Season(date);
            //string dayOfWeek = date.DayOfWeek.ToString();

            //Console.WriteLine($"{season} {dayOfWeek}");
            //static string Season(DateTime date)
            //{
            //    if (date.Month == 12 || date.Month == 1 || date.Month == 2)
            //    {
            //        return "Winter";
            //    }
            //    else if (date.Month >= 3 && date.Month <= 5)
            //    {
            //        return "Spring";
            //    }
            //    else if (date.Month >= 6 && date.Month <= 8)
            //    {
            //        return "Summer";
            //    }
            //    else
            //    {
            //        return "Autumn";
            //    }
            //}

            //Задание №6
            //Console.WriteLine("1 — фаренгейт --> цельсий или 2 — цельсий --> фаренгейт");
            //int choice = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите температуру:");
            //double temperature = double.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    double celsius = (temperature - 32) * 5 / 9;
            //    Console.WriteLine($"Температура в цельсиях: {celsius}");
            //}
            //else if (choice == 2)
            //{
            //    double fahrenheit = (temperature * 9 / 5) + 32;
            //    Console.WriteLine($"Температура в фаренгейтах: {fahrenheit}");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //Задание №7
            Console.WriteLine("Enter 2 number:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);
            Console.WriteLine("All numbers %2=0:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
