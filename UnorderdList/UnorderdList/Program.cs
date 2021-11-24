using System;
using System.IO;

namespace UnorderdList
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\AKASH\source\repos\DataStructuredProblems2\UnorderdList\UnorderdList\demo.txt";
            string[] data = File.ReadAllLines(path);
            LinkedList obj = new LinkedList();

            foreach (string i in data)
            {
                obj.add(i);  
            }
            Console.WriteLine("===========================");
            obj.delete(" hi");
            Console.WriteLine("===========================");
            obj.Display();
        }
    }
}
