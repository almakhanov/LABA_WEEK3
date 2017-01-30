using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MAX
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\n_almakhanov\Desktop\input.txt");

            System.Console.WriteLine("Contents of Input.txt = " + "\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            int maxi=0;

            for (int i = 0; i < lines.Length; i++)
            {

                if (maxi < int.Parse(lines[i]))
                {
                    maxi = int.Parse(lines[i]);
                }
            }
            Console.WriteLine("\n"+"Max number is: "+maxi);


                Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

            
        }
    }
}

