using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace list_v_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string file_size = "50k";  //test, 1k, 10k, 50k, 100k
            string path = "C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size + ".txt";
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size + ".txt");
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


            string structure = "array";  //linked or array
            string action = "insert";     //insert, delete, sort, search
            string datatype = "string";  //string or int
            string condition = "random"; //normal or random
            string value = structure + "_" + action + "_" + datatype + "_" + condition;
            Console.WriteLine(value);

            //inserting into linked list
            switch (value)
            {
                case ("linked_insert_string_normal"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.AddLast(line);
                        }
                        sw.Stop();
                        break;
                    }
                case ("linked_delete_string_normal"):
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.Remove(line);
                        }

                        sw.Stop();
                        break;
                    }
                case ("linked_sort_string_normal"):
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
                case ("linked_search_string_normal"):
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
                case ("array_insert_string_normal"):
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
                case ("array_delete_string_normal"):
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
                case ("array_search_string_normal"):
                    {
                        int i = 0;
                        string[] array_2 = new string[4];
                        while ((line = file.ReadLine()) != null)
                        {
                            
                            array[i] = line;
                            i++;
                        }
                        array.CopyTo(array_2,0);

                        for(int s=0; s<array.Length; s++)
                        {
                            if(array[s]==array_2[s])
                            {
                                sw.Start();
                                Console.WriteLine("found");
                            }
                            
                        }
                        sw.Stop();
                        break;
                    }
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
                        for (int write = 0; write < array.Length; write++)
                        {
                            for (int sort = 0; sort < array.Length - 1; sort++)
                            {
                                if (array[sort][0] > array[sort + 1][0])
                                {
                                    temp = array[sort + 1];
                                    array[sort + 1] = array[sort];
                                    array[sort] = temp;
                                }
                            }
                        }
                        sw.Stop();
                        foreach (string s in array)
                            Console.WriteLine(s);
                        break;
                    }
                case ("array_insert_string_random"):
                    {
                        //Array Numbers = new Array[lines];

                        int[] numbers = new int[lines];
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            numbers[j] = j;
                        }
                        Random rnd = new Random();
                        int[] random_array = numbers.OrderBy(x => rnd.Next()).ToArray();
                        int i = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            array[random_array[i]] = line;
                            i++;
                        }
                        sw.Stop();
                        break;
                    }
                case ("array_delete_string_random"):
                    {
                        int[] numbers = new int[lines];
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            numbers[j] = j;
                        }
                        Random rnd = new Random();
                        int[] random_array = numbers.OrderBy(x => rnd.Next()).ToArray();
                        int i = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            array[random_array[i]] = null;
                            i++;
                        }
                        sw.Stop();
                        break;
                    }
                case ("linked_insert_string_random"):
                    {
                        int[] numbers = new int[lines];
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            numbers[j] = j;
                        }
                        Random rnd = new Random();
                        int[] random_array = numbers.OrderBy(x => rnd.Next()).ToArray();
                        int i = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            sw.Start();
                            linked.AddLast(line);
                            i++;
                        }
                        sw.Stop();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid case");
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