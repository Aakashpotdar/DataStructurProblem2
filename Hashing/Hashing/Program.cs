using System;
using System.IO;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\AKASH\source\repos\DataStructuredProblems2\Hashing\Hashing\nums.txt";
            string writingpath = @"C:\Users\AKASH\source\repos\DataStructuredProblems2\Hashing\Hashing\num2.txt";

            HashingFunction hashObj = new HashingFunction();
            string[] data=ReadAllLines(path);
            foreach(string i in data)
            {
                int num = int.Parse(i);
                int num2 = num % 11;
                hashObj.hashFunction(num2,num);
            }
            Console.WriteLine("enter thenumber u want to write in file");
            int num1 = int.Parse(Console.ReadLine());

            int num3=(hashObj.search(num1));
            StreamWriter sw = new StreamWriter(writingpath);
            sw.WriteLine(num3);

            string[] ReadAllLines(string Path)
            {
                string[] data = File.ReadAllLines(Path);
                return data;
            }
        }

        
    }

}
