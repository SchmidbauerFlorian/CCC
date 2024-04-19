﻿namespace CCC
{
    internal class Program
    {
        public static StreamReader SR { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


        }
    }


    public class Extractor
    {

        public static List<string> Extract(string path, string sep = " ", int startToRead = 0)
        {
            SR = new StreamReader(path);
            List<string> strings = new List<string>();
            int counter = 0;
            while (!SR.EndOfStream)
            {
                if (counter >= startToRead)
                    strings.AddRange(SR.ReadLine().Trim().Split(sep));
                else
                    SR.ReadLine();
                counter++;
            }
            return strings;
        }
    }
}