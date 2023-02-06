using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //исходный файл


            StreamReader f = new StreamReader("/Users/albertselev/Projects/123456/123456/1.txt");
            //файл для записи дней
            StreamWriter f1 = new StreamWriter("/Users/albertselev/Projects/123456/123456/2.txt");
            //файл для записи месяцев
            StreamWriter f2 = new StreamWriter("/Users/albertselev/Projects/123456/123456/3.txt");
            //пока не дойдем до конца исходного файла
            while (!f.EndOfStream)
            {
                //считываем строку из сходного файла с переходом на следующую
                string s = f.ReadLine();
                //выводим на экран считанную строку
                Console.WriteLine(s);
                //приобразуем строку в дату
                DateTime d = DateTime.Parse(s);
                //выводим дату
                Console.WriteLine(d);
                //выводим день даты
                Console.WriteLine(d.Day);
                //выводим месяц даты
                Console.WriteLine(d.Month);
                //записываем день в файл
                f1.WriteLine(d.Day);
                //записываем месяц в файл
                f2.WriteLine(d.Month);


            }
            //закрываем все файлы
            f.Close();
            f1.Close();
            f2.Close();
            //ожидаем ввода, что бы увидеть результат выполнения
            Console.ReadKey();
        }
    }
}