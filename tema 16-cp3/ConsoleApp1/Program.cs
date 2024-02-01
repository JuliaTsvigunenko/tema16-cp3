using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задача1

            //Console.Write("Year ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mounth ");
            //int mounth = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Day ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //DateClass dateClass = new DateClass(year, mounth, day);

            ////для первого способа
            //dateClass.DateOfThePreviousDay();
            //dateClass.NextDay();
            //dateClass.DaysToTheEndOfTheMonth();



            //для второго способа
            //dateClass.Yesterday();
            //dateClass.Tomorrow();
            //dateClass.Mounth();




            //задача2

            //сначала вводим 1ую дату
            //Console.WriteLine("Введите первую дату: ");
            //DateTime oneDate = DateTime.Parse(Console.ReadLine());
            
            ////потом вводим 2ую дату
            //Console.WriteLine("Введите вторую дату: ");
            //DateTime twoDate = DateTime.Parse(Console.ReadLine());

            //// Мы высчитываем разницу (Difference)
            //// TimeSpan используется для представления временной разницы между этими датами. Когда мы вычитаем одну дату из другой
            //TimeSpan timeDifference = oneDate - twoDate;

            //Console.WriteLine($"Количество дней между датами: {timeDifference.Days}");




            //задача3


            Console.Write("Введите время первой процедуры: ");
            DateTime beginTime1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите время второй процедуры процедуры: ");
            DateTime beginTime2 = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите общее количество процедур: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Расписание процедур: ");
            for (int i=0; i<a; i++)
            {
                DateTime currentDate = beginTime1.AddMinutes(i * (beginTime2 - beginTime1).TotalMinutes);
                Console.WriteLine($"Расписание процедур {i + 1}: {currentDate.ToShortTimeString()}");
            }

            //currentDate - текущая дата

            Console.ReadKey();


        }
    }
}
