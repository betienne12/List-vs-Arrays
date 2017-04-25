using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
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
            //string file_size = "1k";  //test, 1k, 10k, 50k, 100k
            string[] file_size = new string[4] { "1k", "10k", "50k", "90k" };
            int z = 0;
            string structure = "linked";  //linked or array
            string action = "search";     //insert, delete, sort, search
            string datatype = "string";  //string or int
            string condition = "normal"; //normal or random
            string value = structure + "_" + action + "_" + datatype + "_" + condition;
            System.IO.StreamWriter output = new StreamWriter("C:\\Users\\Brian\\Desktop\\dictionaries\\" + value + ".txt", true);
            while (z < file_size.Length)
            {
                Console.WriteLine("\n\n\n");
                string path = "C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size[z] + ".txt";
                System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size[z] + ".txt");
                
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
                                
                                linked.AddLast(line);
                            }
                            file.Close();
                            System.IO.StreamReader test = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size[z] + ".txt");

                            while ((line = test.ReadLine()) != null)
                            {
                                sw.Start();
                                linked.Remove(line);

                            }
                            //linked delete
                            sw.Stop();
                            test.Close();
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
                            Random rnd = new Random();
                            List<string> random_list = linked2.OrderBy(x => rnd.Next()).ToList();
                            sw.Start();
                            foreach (string word in random_list)
                            {
                                
                                linked.Find(word);
                                Console.WriteLine("found");
                               
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
                    case ("listarray_insert_string_normal"):
                     {
                            List<string> list = new List<string>();
                            //string[] arr;
                            while ((line = file.ReadLine()) != null)
                            {
                                sw.Start();
                                list.Add(line);
                                
                            }
                        
                            string [] arr = list.ToArray();
                            sw.Stop();
                            break;
                        }
                    case ("listarray_delete_string_normal"):
                        {
                            int i = 0;
                            List<string> list = new List<string>();
                            while ((line = file.ReadLine()) != null)
                            {
                                sw.Start();
                                list.Add(line);

                            }
                            
                            i = 0;
                            file.Close();
                            System.IO.StreamReader test = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size[z] + ".txt");

                            while ((line = test.ReadLine()) != null)
                            {
                                sw.Start();
                                list.Remove(line);
                            }

                            string[] arr = list.ToArray();
                            sw.Stop();
                            test.Close();
                            break;
                        }
                    case ("array_delete_string_normal"):
                        {
                            int i = 0;
                           
                            while ((line = file.ReadLine()) != null)
                            {
                                array[i] = line;
                                i++;

                            }
                            i = 0;
                            while (i < array.Length)
                            {
                                sw.Start();
                                for (int a =i; a < array.Length - 1; a++)
                                {
                                    // moving elements downwards, to fill the gap at [index]
                                    array[a] = array[a + 1];
                                }
                                // finally, let's decrement Array's size by one
                                Array.Resize(ref array, array.Length - 1);
                                i++;
                            }
                            sw.Stop();
                            break;
                        }
                    case ("array_search_string_normal"):
                        {
                            int i = 0;

                            string[] array_2 = new string[lines];
                            

                            while ((line = file.ReadLine()) != null)
                            {

                                array[i] = line;
                                i++;
                            }
                            Random rnd = new Random();
                            string[] random_array = array.OrderBy(x => rnd.Next()).ToArray();
                            
                            //array.CopyTo(array_2, 0);
                            sw.Start();
                            for (int s = 0; s < array.Length; s++)
                            {
                                for (int x=0; x<random_array.Length; x++ )
                                {
                                    if (array[s] == random_array[x])
                                    {
                                        Console.WriteLine("found");
                                    }
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
                            while (i<random_array.Length)
                            {
                                sw.Start();
                                for (int a = random_array[i]; a < array.Length - 1; a++)
                                {
                                    // moving elements downwards, to fill the gap at [index]
                                    array[a] = array[a + 1];
                                }
                                // finally, let's decrement Array's size by one
                                Array.Resize(ref array, array.Length - 1);
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


                            for (int j = 0; j < lines; j++)
                            {

                                linked.AddLast(j.ToString());
                            }
                            int i = 0;
                            while ((line = file.ReadLine()) != null)
                            {
                                sw.Start();
                                linked.Find((random_array[i]).ToString()).Value = line;
                                i++;
                            }
                            sw.Stop();

                            foreach (string item in linked)
                            {
                                Console.WriteLine(item);
                            }

                            break;
                        }
                    case ("linked_delete_string_random"):
                        {
                            int[] numbers = new int[lines];
                            for (int j = 0; j < numbers.Length; j++)
                            {
                                numbers[j] = j;
                            }

                            Random rnd = new Random();
                            int[] random_array = numbers.OrderBy(x => rnd.Next()).ToArray();


                            for (int j = 0; j < lines; j++)
                            {

                                linked.AddLast(j.ToString());
                            }
                            int i = 0;
                            while ((line = file.ReadLine()) != null)
                            {
                                sw.Start();
                                linked.Remove((random_array[i]).ToString());
                                i++;
                            }
                            sw.Stop();

                            foreach (string item in linked)
                            {
                                Console.WriteLine(item);
                            }

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
          
                file.Close();
                string time = string.Format("\nMili seconds :{0}", sw.Elapsed.TotalMilliseconds);
                
                output.WriteLine(time);
                sw.Reset();
                z++;
            }
            output.Close();
            }
        }
    }