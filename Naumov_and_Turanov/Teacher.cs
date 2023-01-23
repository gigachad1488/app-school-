using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naumov_and_Turanov
{
    public class Teacher
    {
        public string Name;
        public int Age;
        public string Discipline;
        public int ShowAgeInYear(int year)
        {
            return Math.Abs((DateTime.Now.Year - Age) - year);
        }
        public void SayHello()
        {
            System.Console.WriteLine($"Здравствуйте, дети! Меня зовут {Name}, мне {Age} и я ваш учитель по {Discipline}! А как зовут тебя?");
        }
    }
}
