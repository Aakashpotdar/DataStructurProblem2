using System;
using System.IO;

namespace OrderdList
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\AKASH\source\repos\DataStructuredProblems2\OrderdList\OrderdList\data.txt";
            string[] data = File.ReadAllLines(path);
            LinkedList obj = new LinkedList();
            Array.Sort(data);
            foreach(string i in data)
            {
                obj.add(i);
            }
            obj.Display();
        }
    }
}
