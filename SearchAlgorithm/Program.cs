using System;
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
            } while ((ch == 'y'));
        }

    public void LinearSearch()
        {
            char ch;
            // search for number of comparasion
            int ctr;
            do
            {
                // accept the number to be seaarched
                Console.WriteLine(" Enter the element you want to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " Found at posistion "
                            + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " not found in the array ");
                Console.WriteLine("\n Number of Comparasion " + ctr);
                Console.Write("\n Continue Search (y/n): ");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program MyList = new Program();
            int Pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("===========");
                    Console.WriteLine("1. linear Search");
                    Console.WriteLine("2. Binary Search");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choise (1,2,3) : ");
                    Pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (Pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("..............");
                            Console.WriteLine(" Linear Search");
                            Console.WriteLine("..............");
                            MyList.input();
                            MyList.LinearSearch();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("..............");
                            Console.WriteLine(" Binary Search");
                            Console.WriteLine("..............");
                            MyList.input();
                            MyList.BinarySearch();
                            break;
                        case 3:
                            Console.WriteLine(" Exit");
                            break;
                        default:
                            Console.WriteLine(" Error");
                            break;
                    }
                    Console.WriteLine("\n Pilih Menu Lagi? (y/n): ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                // to exit from the console
                Console.WriteLine("\n\n Press Return to exit. ");
                Console.ReadLine();
            } while (Pilihanmenu != 3);
        }
    }
}
