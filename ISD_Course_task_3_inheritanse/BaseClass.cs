using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_3_inheritanse
{
    class BaseClass
    {
        protected ConsoleColor textColor;
        public BaseClass()
        {
            textColor = ConsoleColor.Blue;
        }
        public virtual void Print(string Text)
        {
            Console.ForegroundColor = this.textColor;
            Console.WriteLine(Text);
            Console.ResetColor();
        }
    }
    class Daughter : BaseClass
    {
        public Daughter()
        {
            this.textColor = ConsoleColor.DarkRed;
        }
    }
}
