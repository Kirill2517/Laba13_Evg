using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DateBirthday : Date
    {
        public List<People> Peoples { get; private set; }  //количество именников в этот день
        public DateBirthday(DateTime dateTime) : base(dateTime)
        {
            Peoples = new List<People>();
        }

        public void Add(People people)
        {
            if (people.DateBirthday.DateTime.Month == DateTime.Month &&
                people.DateBirthday.DateTime.Day == DateTime.Day) Peoples.Add(people);
        }

        public void Print()
        {
            Console.WriteLine($"сегодня {DateTime}");
            Console.WriteLine($"{DateTime.Month}/{DateTime.Day} родились {Peoples.Count} человек: ");
            foreach (var item in Peoples)
            {
                Console.WriteLine(item);
            }
        }
    }
}
