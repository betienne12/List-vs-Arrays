using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string line;
            string low;
            string file_size = "test";  //test, 1k, 10k, 50k, 100k
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Brian\\Desktop\\dictionaries\\" + file_size + ".txt");

            string path = "C:\\Users\\Brian\\Desktop\\dictionaries\\Test_2.txt";
            System.IO.StreamWriter output = new System.IO.StreamWriter(path);
            while ((line = file.ReadLine()) != null)
            {
                low = line.ToLower();
                output.WriteLine(low);
            }
            output.Close();
            file.Close();
            File.WriteAllLines(path, File.ReadAllLines(path).Where(l => !string.IsNullOrWhiteSpace(l)));*/
            string num = "127";
            int q = Convert.ToInt32(num);
            Console.WriteLine(q);

        }
    }
}
