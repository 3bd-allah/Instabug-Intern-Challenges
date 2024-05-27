using System.Collections.Concurrent;
using System.IO;
using System.Net.Http.Headers;
namespace Challenge1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // reading data from (input.txt)
            using var streamReader = new StreamReader("H:\\Instabug intern\\Instabug Intern\\Challenge1/input.txt");
            string? lineStr = streamReader.ReadLine();

            // initalizing parameters lists
            List<int> req = new List<int>();
            List<int> cap = new List<int>();

            // create stream Writer object to print output to external file (output.txt)
            StreamWriter output = new StreamWriter("H:\\Instabug intern\\Instabug Intern\\Challenge1/output.txt");


            while (lineStr != null)
            {
                //Console.WriteLine(lineStr);
                // convert reading form file from string to list of integers
                req = lineStr.TrimEnd().Split(" ").ToList().Select(x => int.Parse(x)).ToList();
                lineStr = streamReader.ReadLine();
                //Console.WriteLine(lineStr);
                cap = lineStr.TrimEnd().Split(" ").ToList().Select(x => int.Parse(x)).ToList();
                output.WriteLine(Test(req, cap));
                //Console.WriteLine(Test(req, cap));
                lineStr = streamReader.ReadLine();

                // clear parameters lists
                
                req.RemoveRange(0, req.Count);
                cap.RemoveRange(0, cap.Count);

            }
            // to close the stream 
            output.Flush();
            output.Close();

        }

        public static int Test(List<int> requirements, List<int> capacity)
        {
            int R = capacity[0] / requirements[0],
                C = capacity[1] / requirements[1],
                D = capacity[2] / requirements[2];
            int smaller = (int)Math.Min(R, C);

            int maxNoOfAppliedMachines = (int)Math.Min(smaller, D);


            return maxNoOfAppliedMachines;
        }
    }
}


