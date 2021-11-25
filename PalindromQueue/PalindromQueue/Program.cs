using Nito.Collections;
using System;
using System.Collections;
using Nito.Collections;

namespace PalindromQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello enter th name to check the palindrom");
            string input = Console.ReadLine();

            Deque<char> Name = new Deque<char>();
           Deque<char> reverseName = new Deque<char>();
            int Le = input.Length-1,count=0;
            for(int i = 0; i <=Le; i++)
            {
                Name.AddToFront(input[i]);
                reverseName.AddToFront(input[i]);
            }
            for (int i = 0; i < Le; i++)
            {
                char a = Name.RemoveFromFront();
                char b = reverseName.RemoveFromBack();
                if (a!=b)
                {
                    Console.WriteLine("string is not palindrom");
                    count++;
                    break;
                }
            }

            if(count==0)
            Console.WriteLine("the entered string is palindrom ");
           
        }
    }
}
