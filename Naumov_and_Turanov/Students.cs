using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naumov_and_Turanov
{
    public class Students
    {
        private string names;
        public int Ages;
        public Teacher teachers;
        public Students(string name,int age, Teacher teac) 
        {
            names = name;
            Ages = age;
            teachers = teac;
        }
        public string Names
        {
            get
            {
                return names;
            }
            set
            {
                if (value == " ")
                {
                    Console.WriteLine("Не дано имя!");
                }
                else
                {
                    names = value;
                }
            }
        }
        public void SayHi()
        {
            Console.WriteLine($"Здравствуйте учитель {teachers?.Name}, меня зовут {names}, мне {Ages} лет и я очень счатлив!");
        }   
    }
}
