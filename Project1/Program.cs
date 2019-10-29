using System;
using System.Globalization; //для определения точки разделителем

namespace Project1
{
    class Program
    {
       public static string NumberDecimalSeperator { get; private set; }

        static void Main(string[] args)
        {
            //для точки разделителя
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            {
                NumberDecimalSeperator = ".";
            };


            Console.WriteLine("Hello");
            //или так если писать полностью
            System.Console.WriteLine("Привет!");

            //объявление переменных:
            //тип данных имя переменной
            int a, b;
            //инициализация - первое присвоение значения переменной
            a = 5;
            b = 99;

            double c = 1.33;

            char aa = 'a';
            string a1 = "abc";

            Console.WriteLine("A=", a);

            //чтение из консоли- это будет всегда строка
            string data;
            data=Console.ReadLine();

            //конвертация в число (ввести не число - будет ошибка)
            int data1=Convert.ToInt32(data);
            data1++;
            Console.WriteLine("Привет " + data1 + "!!!");

            //конвертация методами parse и tryparse
            data = "5";
            data1=int.Parse(data);

            data = "5.9"; //разделитель дробных чисел запятая а не точка
            double a2 = double.Parse(data, numberFormatInfo);
            a2 = a2 + 8.987;
            Console.WriteLine("A2 " + a2);

            //конвертация с try-catch
            string str = "1fdfg";
            try
            {
                int a3 = Convert.ToInt32(str);
                Console.WriteLine("Успешно");
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка");
            }

            //конвертация с parse
            string str1 = "1";
            try
            {
                int a3 = int.Parse(str1);
                Console.WriteLine("Успешно");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }

            //метод tryparse
            int a4;
            //возвращает логику получилось / не получилось и а4 - результат
            bool res1 = int.TryParse(str1, out a4);

            //приведение типов иначе результат будет int
            int q, w;
            q = 4; w = 7;

            double result = (double)q / w;

            //остаток от деления
            int res2 = q % w;



        }
    }
}
