using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile001
{
    public class FileDemo
    {
        public static void ReadDemo(string file)
        {
            string path = "c:/users/outsi/downloads";
            //string file = "jamaica.txt";
            string fileToRead = $"{path}/{file}";

            Console.WriteLine($"Reading {fileToRead}");
            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {

                    Console.WriteLine($"Starting to Reading {fileToRead}");

                    string line;


                    while ((line = sr.ReadLine()) is not null)
                    {
                        Console.WriteLine($"\t{line}");

                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }

        }

        // Formatting string example
        // https://stackoverflow.com/questions/644017/net-format-a-string-with-fixed-spaces
        //string s = "String goes here";
        //string lineAlignedRight = String.Format("{0,27}", s);
        //string lineAlignedCenter = String.Format("{0,-27}",
        //    String.Format("{0," + ((27 + s.Length) / 2).ToString() + "}", s));
        //string lineAlignedLeft = String.Format("{0,-27}", s);




        public static void ReadAndParseString(string file)
        {
            string path = "c:/users/outsi/downloads";
            //string file = "jamaica.txt";
            string fileToRead = $"{path}/{file}";

            //Console.WriteLine($"Reading {fileToRead}");
            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {

                    string line;
                    while ((line = sr.ReadLine()) is not null)
                    {

                        string[] splitData = line.Split(":");
                        Console.WriteLine($"\t{String.Format("{0,-20}", splitData[0])}\t{splitData[1]}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message)
            }
        }
        public static void WriteDemo(string file, string[] heroes)
        {
          

            string path = "c:/users/outsi/downloads";
            //string file = "heroes.txt";
            string fileToWrite = $"{path}/{file}";

            using(StreamWriter sw = new StreamWriter(fileToWrite))
            {

                foreach(string s in heroes)
                {

                    sw.WriteLine(s);
                }

            }
         //   Console.WriteLine("Done");
            //Console.ReadKey();

        }
    
    }
}
