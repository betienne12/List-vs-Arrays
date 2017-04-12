using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_v_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int cnt=0;
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\1k.txt");
            LinkedList<string> linked = new LinkedList<string>();
            while ((line = file.ReadLine()) != null)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                linked.AddLast(line);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

            }
            Console.WriteLine(elapsedMs);
            file.Close();
        }
     }
   }