using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DateClass
    {

        //Задание 1.


        DateTime data;

        /// <summary>
        /// конструктор без параметров;
        /// </summary>
        public DateClass()
        {

        }

        /// <summary>
        /// конструктор, позволяющий установить: заданную дату(конструктор с тремя параметрами – год, месяц, день);
        /// </summary>
        /// <param name="year"></param>
        /// <param name="mounth"></param>
        /// <param name="day"></param>
        public DateClass(int year, int mounth, int day)
        {
            data = new DateTime(year, mounth, day);

        }

        public DateTime Data
        { get { return data; } set { data = value; } }



        //      ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ЗАДАЧИ

        public void DateOfThePreviousDay()
        {
            Console.WriteLine($"Дата предыдущего дня: { DateTime.Now.AddDays(-1)}");
        }


        public void NextDay()
        {
            Console.WriteLine($"Дата следующего дня: { DateTime.Now.AddDays(+1)}");
        }


        public void DaysToTheEndOfTheMonth()
        {
            DateTime todaydate = DateTime.Now;

            DateTime firstDayOfNextMonth = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1);

            int daysRemaining = (firstDayOfNextMonth - todaydate).Days;

            Console.WriteLine($"До конца месяца осталось: {daysRemaining}");
        }




        //          ВТОРОЙ СПОСОБ РЕШЕНИЯ ЗАДАЧИ

        //public DateTime Yesterday()
        //{
        //    return data.AddDays(-1);
        //}

        //public DateTime Tomorrow()
        //{
        //    return data.AddDays(1);
        //}

        //public int Mounth()
        //{
        //    return DateTime.DaysInMonth(data.Year.data.Month) - data.Day;
        //}


















    }
}
