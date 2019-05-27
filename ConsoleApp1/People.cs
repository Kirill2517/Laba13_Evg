using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class People
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Weight { get; private set; }
        public int Height { get; private set; }
        public DateBirthday DateBirthday { get; private set; }
        public People(string name, int age, int weight, int height, DateBirthday dateBirthday)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            DateBirthday = dateBirthday;
        }

        public override string ToString()
        {
            return Name + " Age:" + Age + " " + DateBirthday.DateTime.Year +
                "/" + DateBirthday.DateTime.Month + "/" + DateBirthday.DateTime.Day;
        }
    }
}
