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
            Array[] array;
            List<string> linked2 = new List<string>();
            Stopwatch sw = new Stopwatch();
           
            string value = "search";
            
            //inserting into linked list
            switch (value)
            {
                case("linked_insert"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.AddLast(line);
                        }
                        sw.Stop();
                        break;
                    }
                case ("linked_delete"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.Remove(line);
                        }

                        sw.Stop();
                        break;
                    }
                case ("linked_sort"):
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
                case ("linked_search"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            linked.AddLast(line);
                        }
                        linked2 = linked.ToList();

                        foreach (string  word in linked2)
                        {
                            sw.Start();
                            linked.Find(word);
                        }
                        sw.Stop();
                        break;
                    }
                case ("array_insert"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            array.
                        }

                        break;
                    }
                case ("array_delete"):
                    {
                        break;
                    }
                case ("array_search"):
                    {
                        break;
                    }
                case ("array_sort"):
                    {
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