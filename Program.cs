using System;
using System.IO;

namespace ReadFile001
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileDemo.ReadDemo("jamaica.txt");

            string dc_heroesFile = "heroes-dc.txt";
            string[] dc_heroes = { "Batman", "Superman", "Aquaman" };
            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);
            FileDemo.ReadDemo(dc_heroesFile);


            string marvel_heroesFile = "heroes-marvel.txt";
            string[] marvel_heroes = { "SpiderMan", "The Hulk", "Thanos" };
            FileDemo.WriteDemo(marvel_heroesFile, marvel_heroes);
            FileDemo.ReadDemo(marvel_heroesFile);






        }
    }
}
