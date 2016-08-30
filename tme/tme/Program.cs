using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tme
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromFile();
            
        }

        private static void ReadFromFile()
        {
            List<int> line = new List<int>();
            string[] numbers;
            int count = 0;
            string key = string.Empty;

            try
            {
                string[] allLines = File.ReadAllLines("input.txt");

                foreach (var splitedLine in allLines)
                {
                    numbers = splitedLine.Split(',');
                    var l = numbers.GroupBy(i => i);
                    foreach (var number in l)
                    {
                        if(number.Count() > count)
                        {
                            count = number.Count();
                            key = number.Key;
                        }
                        else if (number.Count() == count)
                        {
                            key = "None";
                        }
                    }
                    Console.WriteLine("Major element: {0}", key);
                    count = 0;
                    key = string.Empty;
                }
            }
            catch { }

            
        }

        private static void FindMajorElement(List<int> line)
        {
            //foreach (int item in line)
            //{
            //    line.find
            //}
        }
    }
}
