using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naumov_and_Turanov
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Age = 35;
            teacher.Name = "Олег";
            teacher.Discipline = "История и общество";
            teacher.SayHello();
            Console.Read();
            Students student = new Students(Console.ReadLine().ToString(), 16, teacher);
            student.SayHi();
            Console.Read();
            Lesson les = new TimeLesson();
            les.Les();
            Console.ReadKey();
        }
    }
    
}
