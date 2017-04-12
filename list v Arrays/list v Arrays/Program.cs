using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace list_v_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\1k.txt");
            LinkedList<string> linked = new LinkedList<string>();
            Stopwatch sw = new Stopwatch();
            while ((line = file.ReadLine()) != null)
            {
                sw.Start();
                linked.AddLast(line);              
            }
            sw.Stop();
            string ExecutionTimeTaken = string.Format("Minutes :{0}\nSeconds :{1}\n Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            Console.WriteLine(ExecutionTimeTaken);
            sw.Reset();
            file.Close();
        }
     }
   }