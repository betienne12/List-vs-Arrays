using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100k
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string structure = "array";  //linked or array
            string action = "sort";     //insert, delete, sort, search
            string datatype = "string";  //string or int
            string condition = "normal"; //normal or random
            string value = structure + "_" + action + "_" + datatype + "_" + condition;
            System.IO.StreamWriter output = new StreamWriter("C:\\Users\\Brian\\Desktop\\dictionaries\\" + value + ".txt", true);
            string path = "C:\\Users\\Brian\\Desktop\\dictionaries\\" + "100k" + ".txt";
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + "100k" + ".txt");

            int lines = File.ReadAllLines(path).Length;
            LinkedList<string> linked = new LinkedList<string>();
            string[] array = new string[lines];
            List<string> linked2 = new List<string>();
            Stopwatch sw = new Stopwatch();


            Random rand = new Random();
            int w = rand.Next(1, lines);
            var lineToRead = w;
            //Console.WriteLine("number is {0}", w);
            var requiredLine = System.IO.File.ReadLines(path).Skip(lineToRead - 1).First();
            switch (value)
            {
                case ("array_sort_string_normal"):
                    {
                        int i = 0;
                        while ((line = file.ReadLine()) != null)
                        {

                            array[i] = line;
                            i++;
                        }
                        string temp = null;
                        sw.Start();
                        for (int write = 0; write <= 90000; write++)
                        {
                            for (int sort = 0; sort <=90000; sort++)
                            {
                                //Console.WriteLine(array[sort]);
                                if (array[sort][0] > array[sort + 1][0])
                                {
                                    temp = array[sort + 1];
                                    array[sort + 1] = array[sort];
                                    array[sort] = temp;
                                }
                                
                            }
                        }
                        sw.Stop();

                        break;
                    }
                    
            }
            string ExecutionTimeTaken = string.Format("Minutes :{0}\nSeconds :{1}\n Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
                    int c = linked.Count();
                    int d = array.Count();
                    Console.WriteLine("There are {0} items in the linked list", c);
                    Console.WriteLine("There are {0} items in the array", d);
                    Console.WriteLine(ExecutionTimeTaken);
        }
    }
}
