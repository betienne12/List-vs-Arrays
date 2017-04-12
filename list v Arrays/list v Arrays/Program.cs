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
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\test.txt");
            LinkedList<string> linked = new LinkedList<string>();
            List<string> linked2 = new List<string>();
            Stopwatch sw = new Stopwatch();
            string value = "sort"; 
            //inserting into linked list
            switch (value)
            {
                case("insert"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.AddLast(line);
                        }
                        sw.Stop();
                        break;
                    }
                case ("delete"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.Remove(line);
                        }

                        sw.Stop();
                        break;
                    }
                case ("sort"):
                    {
                        
                        while ((line = file.ReadLine()) != null)
                        {
                            
                            linked.AddLast(line);
                        }
                        sw.Start();
                        //linked2 = linked.OrderByDescending().ToList();
     
                        sw.Stop();
                        foreach (string s in linked2)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    }
                case ("search"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            linked.AddLast(line);
                        }
                        linked.to
                        break;
                    }
            }
            string ExecutionTimeTaken = string.Format("Minutes :{0}\nSeconds :{1}\n Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            int c = linked.Count();
            Console.WriteLine("There are {0} items", c);
            Console.WriteLine(ExecutionTimeTaken);
            sw.Reset();
            file.Close();
        }
     }
   }