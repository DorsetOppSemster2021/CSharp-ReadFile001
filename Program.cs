using System;
using System.IO;

namespace ReadFile001
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileDemo.ReadDemo("jamaica.txt");

            string heroesFile = "heroes.txt";
         
            FileDemo.WriteDemo(heroesFile);

            FileDemo.ReadDemo(heroesFile);

        }
    }
}
