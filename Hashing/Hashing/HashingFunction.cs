using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
	class HashingFunction
	{
		LinkedListClass[] order = new LinkedListClass[11];
		LinkedListClass hf0 = new LinkedListClass();
		LinkedListClass hf1 = new LinkedListClass();
		LinkedListClass hf2 = new LinkedListClass();
		LinkedListClass hf3 = new LinkedListClass();
		LinkedListClass hf4 = new LinkedListClass();
		LinkedListClass hf5 = new LinkedListClass();
		LinkedListClass hf6 = new LinkedListClass();
		LinkedListClass hf7 = new LinkedListClass();
		LinkedListClass hf8 = new LinkedListClass();
		LinkedListClass hf9 = new LinkedListClass();
		LinkedListClass hf10 = new LinkedListClass();

		public void hashFunction(int rem,int num)
		{
            switch (rem)
            {
				case 0:
					order[rem] = hf0;
					hf0.add(num);
					break;
				case 1:
					order[rem] = hf1;
					hf1.add(num);
					break;
				case 2:
					order[rem] = hf2;
					hf2.add(num);
					break;
				case 3:
					order[rem] = hf3;
					hf3.add(num);
					break;
				case 4:
					order[rem] = hf4;
					hf4.add(num);
					break;
				case 5:
					order[rem] = hf5;
					hf5.add(num);
					break;
				case 6:
					order[rem] = hf6;
					hf6.add(num);
					break;
				case 7:
					order[rem] = hf7;
					hf7.add(num);
					break;
				case 8:
					order[rem] = hf8;
					hf8.add(num);
					break;
				case 9:
					order[rem] = hf9;
					hf9.add(num);
					break;
				case 10:
					order[rem] = hf10;
					hf10.add(num);
					break;
			}
		}
		public int search(int num)
        {
			int num1 = num % 11;
			switch (num1)
			{
				case 0:
					int data0=hf0.search(num);
					return data0;
					break;
				case 1:
					int data1=hf1.search(num);
					return data1;
					break;
				case 2:
					int data2 = hf2.search(num);
					return data2;
					break;
				case 3:
					int data3 = hf3.search(num);
					return data3;
					break;
				case 4:
					int data4 = hf4.search(num);
					return data4;
					break;
				case 5:
					int data5 = hf5.search(num);
					return data5;
					break;
				case 6:
					int data6 = hf6.search(num);
					return data6;
					break;
				case 7:
					int data7 = hf7.search(num);
					return data7;
					break;
				case 8:
					int data8 = hf8.search(num);
					return data8;
					break;
				case 9:
					int data9 = hf9.search(num);
					return data9;
					break;
				case 10:
					int data10 = hf10.search(num);
					return data10;
					break;
			}
			return 0;
        }
	} 
}
