using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Домашнее задание выполнил Козлов Виталий
namespace ConsoleApp2
{
    class Program
    {
       static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            #region         // Прграмма Анкета
               
                Console.WriteLine("программа Анкета.");
                Console.Write("Введите ваше Имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите вашу Фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Введите ваш Возраст: ");
                string age = Console.ReadLine();
                Console.Write("Введите ваш Рост: ");
                string heig = Console.ReadLine();
                Console.Write("Введите ваш Вес: ");
                string weig = Console.ReadLine();
                Console.WriteLine("Вывод информации используя склеивания:\nВаше Имя: " + name + ", Ваша Фамилия: " + surname + ", Ваш Возраст: " + age + ", Ваш Рост: " + heig + "см. Ваш Вес: " + weig + "кг.");
                Console.WriteLine("Вывод информации используя форматированный вывод:\nВаше Имя: {0}, Ваша Фамилия: {1}, Ваш Возраст {2}, Ваш Рост {3}см, Ваш Вес {4}кг.", name, surname, age, heig, weig);
                Console.WriteLine($"Вывод информации используя вывод со знаком $:\nВаше Имя: {name}, Ваша Фамилия: {surname}, Ваш Возраст {age}, Ваш Рост {heig}см, Ваш Вес {weig}кг.");

            #endregion
            #region         //Программа для расчёта индекса массы тела 
            Console.WriteLine("\nПрограмма для расчёта индекса массы тела");
            double i = Convert.ToSingle(weig) / Math.Pow(Convert.ToSingle(heig)/100,2);
            Console.WriteLine($"Ваш ИМТ = {i:f2}");

        #endregion

        #region         //Программа для расчёта расстояния между точками

            Console.WriteLine("\nПрограмма для расчёта расстояния между точками:");
            Console.WriteLine("ВВедите координаты первой точки A1, х1, у1:");
            Console.Write("Введите значение для x1: ");
            float x1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение для у1: ");
            float y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ВВедите координаты второй точки A2, х2, у2:");
            Console.Write("Введите значение для x1: ");
            float x2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение для у2: ");
            float y2 = Convert.ToSingle(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками с координатами A1({x1};{y1}) и A2({x2};{y2}) равно: {r:f2}");
        #endregion

        #region         //Программа для обмена значениями двух переменных

            Console.WriteLine("\nПрограмма для обмена значениями двух переменных");
            Console.WriteLine("Введите значение для переменных a,b");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int a1, b1;
            a1 = a;
            b1 = b;
            int temp;
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"Новые значения переменных:\na={a}, b={b}");
            a1 = a1 + b1;
            b1 = a1 - b1;
            a1 = a1 - b1;
            Console.WriteLine($"\nОбмен значениями 2-х переменных без использования 3-ей переменной:\nНовые значения переменных a={a1}, b={b1}");
         
        #endregion
       
         #region         //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания

            Console.Write("введите Ваш город проживания: ");
            string city = Console.ReadLine();
            Console.WriteLine($"{name} {surname}, ты живёшь в городе {city}");
            string text = name + " " + surname + " ты живёшь в городе " + city;
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(text);
            Console.WriteLine("\nВывод сообщения через функцию:");
            int x=(Console.WindowWidth-text.Length)/ 2;
            int y = Console.WindowHeight / 2;
            Print(text, x, y);
            Console.WriteLine("\nВывод сообщения через класс:");
            Lesson01 lesson = new Lesson01();
            lesson.PrintClass(text, x, y);

            #endregion
            lesson.Pause();
            Console.ReadKey();
        }
    }
}
