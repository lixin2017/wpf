using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public class CheckEventArgs : EventArgs
    {
        private readonly string score;

        public CheckEventArgs(string strScore)
        {
            score = strScore;
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public int Page { get; set; }
    }
    public class LeraningCheckMachine
    {
        public int userscore;
        private Book book;

        public delegate void CheckEventHandler(object sender, CheckEventArgs e);

        public  event CheckEventHandler Check;

        protected virtual void OnCheck(CheckEventArgs e)
        {
            if (Check != null)
            {
                Check(this, e);
            }
        }

        public void Learning()
        {
           
            for (int i = 0; i <= 628; i++)
            {
                userscore = i * 100 / 628;
                if (userscore > 90)
                {
                    CheckEventArgs e = new CheckEventArgs(userscore.ToString());
                    OnCheck(e);
                }
            }

        }
    }

    public class Student
    {
        public void Learning(object sender, CheckEventArgs e)
        {
            LeraningCheckMachine leraningCheckMachine = sender as LeraningCheckMachine;
            if (leraningCheckMachine == null)
                return;
            Console.WriteLine(leraningCheckMachine.userscore);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LeraningCheckMachine leraning=new LeraningCheckMachine();
            Student student=new Student();

            leraning.Check += student.Learning;
            leraning.Learning();
        }
    }
}
