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
            string[] dc_heroes = { "Batman:Bruce Wayne", "Superman:Clarke Kent", "Aquaman:Arthur Curry" };
            FileDemo.WriteDemo(dc_heroesFile, dc_heroes);
            FileDemo.ReadAndParseString(dc_heroesFile);

            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/padding
            Console.WriteLine("=".PadRight(80,'='));

            string marvel_heroesFile = "heroes-marvel.txt";
            string[] marvel_heroes = { "SpiderMan:Peter Parker", "The Hulk:David Banner", "Captain America:Steve Rogers" };
            FileDemo.WriteDemo(marvel_heroesFile, marvel_heroes);
            FileDemo.ReadAndParseString(marvel_heroesFile);


            char[] characters = FileDemo.SplitAString("supercalifragilisticexpialidocious");

            Console.WriteLine($"The character at index position 10, live position 11 is {characters[10]}");



        }
    }
}
