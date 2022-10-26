﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of elemenets in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while(true)
            {
                Console.WriteLine("Enter the Number of Elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 elements. \n");
            }
            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter Array Elements ");
            Console.WriteLine("----------------------");
            for ( i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                // accept the number to be searched
                Console.Write
                    ("\n Enter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                // apply benary search
                int lowerbound = 0;
                int upperbound = n - 1;

                // obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // loop to search for the elemenets int the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "Found at position"
                        + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "Not found int the array \n");
                Console.WriteLine ("\n Number of comparasion : " + ctr);

                Console.WriteLine("\n Continue search (y/n)");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
        }
    }
}
