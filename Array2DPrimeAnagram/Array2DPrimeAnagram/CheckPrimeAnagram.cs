using System;
using System.Collections.Generic;
using System.Text;

namespace Array2DPrimeAnagram
{
    public class CheckPrimeAnagram
    {
        public void PrimePrint()
        {
            int[,] arr2D = new int[100, 10];
            int[] arr = new int[1000];
            int ver = 0, hor = 0;
            int check = 0;

            for (int i = 1; i <= 1000; i++)
            {
                check++;
                int num = 0;
                int count = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    num = i % j;
                    if (num == 0)
                        count++;
                }
                if (count == 1)
                {

                    arr2D[ver, hor] = i;
                    ver++;
                }
                count = 0;
                if (check == 100)
                {
                    ver = 0;
                    check = 0;
                    hor++;
                }
            }
            for (int i = 0; i < arr2D.GetLength(1); i++)
            {
                for (int j = 0; j < arr2D.GetLength(0); j++)
                {
                    if ((arr2D[j, i] != 0)&&(checkAnagram(arr2D[j,i])))
                    {
                        Console.Write(arr2D[j, i] + " ");
                    }
                }
                Console.WriteLine();
            };
        }
        public bool checkAnagram(int number)
        {
            int num = number;
            int rev = 0;
            while (number > 0)
            {
                int temp = number % 10;
                rev = (rev * 10) + temp;
                number = number / 10;
            }
            if (num == rev)
            {
                return true;
            }
            return false;
        }
    }
}
