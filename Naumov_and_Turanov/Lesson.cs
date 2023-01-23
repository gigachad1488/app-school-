using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naumov_and_Turanov
{
    abstract class Lesson
    {
        public abstract void Les();
    }
    class TimeLesson : Lesson
    {
        public override void Les()
        {
            Console.WriteLine("Урок начался!");
        }
    }
}
