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
            string file_size = "Test_2";  //test, 1k, 10k, 50k, 100k

            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size + ".txt");
            LinkedList<string> linked = new LinkedList<string>();
            string[] array = new string[4];
            List<string> linked2 = new List<string>();
            Stopwatch sw = new Stopwatch();


            string structure = "linked";  //linked or array
            string action = "sort";     //insert, delete, sort, search
            string datatype = "string";  //string or int
            string value = structure + "_" + action + "_" + datatype;
            Console.WriteLine(value);

            //inserting into linked list
            switch (value)
            {
                case ("linked_insert_string"):
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
                        int i, j, k;
                        string tempData;
                        LinkedListNode<string> next = null;
                        LinkedListNode<string> curr = null;

                        int size = linked.Count;
                        k = size;

                        for (i = 0; i < size - 1; i++, k--)
                        {
                            curr = linked.First;
                            next = linked.First.Next;

                            for (j = 1; j < k; j++)
                            {

                                if (curr.Value[0] > next.Value[0])
                                {
                                    tempData = curr.Value;
                                    curr.Value = next.Value;
                                    next.Value = tempData;
                                }

                                curr = curr.Next;
                                next = next.Next;
                            }
                        }
                        sw.Stop();
                        foreach (string item in linked)
                        {
                            Console.WriteLine(item);
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

                        foreach (string word in linked2)
                        {
                            sw.Start();
                            linked.Find(word);
                        }
                        sw.Stop();
                        break;
                    }
                case ("array_insert_string"):
                    {
                        int i = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            array[i] = line;
                            i++;
                        }
                        sw.Stop();
                        break;
                    }
                case ("array_delete_string"):
                    {
                        int i = 0;
                        int x = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            array[i] = line;
                            i++;

                        }
                        sw.Start();
                        for (x = 0; x < array.Length; x++)
                            array[x] = null;
                        sw.Stop();

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
                    int d = array.Count();
                    Console.WriteLine("There are {0} items in the linked list", c);
                    Console.WriteLine("There are {0} items in the array", d);
                    Console.WriteLine(ExecutionTimeTaken);
                    sw.Reset();
                    file.Close();
            }
        }
    }