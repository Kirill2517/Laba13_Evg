using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random Random = new Random(Guid.NewGuid().ToByteArray().Sum(c => c));
        public static DateTime DateRandom(DateTime year)
        {
            DateTime start = new DateTime(year.Year - 60, 1, 1);
            int range = (year - start).Days;
            return start.AddDays(Random.Next(range));
        }

        static void Main(string[] args)
        {
            DateTime dateTime = DateRandom(DateTime.Now);//генерируем дату
            DateBirthday dateBirthday = new DateBirthday(dateTime);//передаем констр дату

            List<People> peoples = new List<People>();

            for (int i = 0; i < 100000; i++)
            {
                DateBirthday PeopleDateBirthday = new DateBirthday(DateRandom(dateTime));//генерируем дату рождения человека
                People people = new People(Guid.NewGuid().ToString().Remove(7),
                    dateTime.Year - PeopleDateBirthday.DateTime.Year, //задаем параметры человека 
                    new Random(Guid.NewGuid().ToByteArray().Sum(c => c)).Next(1, 100), 
                    new Random(Guid.NewGuid().ToByteArray().Sum(c => c)).Next(1, 100),
                    PeopleDateBirthday);
                peoples.Add(people);
                dateBirthday.Add(people); // передаем человека в список именинников на эту дату
            }







            //Важно! раскомментируй один из двух регионов на твой выбор. ОДИН ИЗ ДВУХ, а другой оставь закоменченным






            #region
            //dateBirthday.Print(); // выводим список именинников
            #endregion

            #region
            //////////////////////////////////////////////////

            //Console.WriteLine("there is");
            //int max = 0;
            //(int m, int d) peopleday = (0, 0);
            //for (int m = 1; m <= 12; m++)
            //{
            //    for (int d = 1; d <= 31; d++)
            //    {
            //        var p = peoples.Where(people => people.DateBirthday.DateTime.Month == m && people.DateBirthday.DateTime.Day == d).Count();
            //        Console.WriteLine($"{m} {d} {p}");
            //        if (p > max)
            //        {
            //            max = p;
            //            peopleday = (m, d);
            //            Console.WriteLine($"{m} {d}\t\t{max}");
            //        }
            //    }
            //}

            //var pep = peoples.Where(people => people.DateBirthday.DateTime.Month == peopleday.m && people.DateBirthday.DateTime.Day == peopleday.d);
            //Console.WriteLine($"больше всего человек родилось {peopleday.m}/{peopleday.d}. Родилось {pep.Count()} людей");

            //foreach (var item in pep)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////////////////////////
            #endregion
        }
    }
}