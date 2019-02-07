using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new testquestion();
            a.playingwithforloops();
        }
    }
    class testquestion
    {
        public int myfavvariable = 0;
        public void playingwithforloops()
        {
            for (; mymethod();)
            {
                if (myfavvariable > 10)
                {
                    Console.WriteLine("I am outof  the for loop");
                    break;
                }
                Console.WriteLine("oh no ihave to go through this stupid loop again");
            }
        }
        public bool mymethod()
        {
            myfavvariable++;
            return true;
        }
    }
}