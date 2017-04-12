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
            string file_size = "test";  //test, 1k, 10k, 50k, 100k
             System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\"+ file_size+ ".txt");
            LinkedList<string> linked = new LinkedList<string>();
            string [] array = new string[4];
            List<string> linked2 = new List<string>();
            Stopwatch sw = new Stopwatch();


            string structure = "linked";  //linked or array
            string action = "insert";     //insert, delete, sort, search
            string datatype = "string";  //string or int
            string value = structure + "_"+ action+"_"+ datatype;
            Console.WriteLine(value);
            
            //inserting into linked list
            switch (value)
            {
                case("linked_insert_string"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.AddLast(line);
                        }
                        sw.Stop();
                        break;
                    }
                case ("linked_delete_string"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.Remove(line);
                        }

                        sw.Stop();
                        break;
                    }
                case ("linked_sort_string"):
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
                case ("linked_search_string"):
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
                case ("array_insert_string"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            for(int i=0; i<=array.Length; i++)
                            {
                                array[i] = line;
                            }
                            sw.Start();
                            
                        }

                        break;
                    }
                case ("array_delete_string"):
                    {
                        break;
                    }
                case ("array_search_string"):
                    {
                        break;
                    }
                case ("array_sort_string"):
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