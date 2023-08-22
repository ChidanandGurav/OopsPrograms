using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class DuplicateNumer
    {
        //6.	WAP to find and count total number of duplicate elements in an array.
        //9.	WAP to count frequency of each element in an array.
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 2, 4, 5, 2, 4, 3, 2, 2, 2 };

            for (int i = 0; i < Arr.Length; i++)
            {
                int cnt = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (Arr[k] == Arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < Arr.Length; j++)
                    {
                        if (Arr[i] == Arr[j])
                        {
                            cnt++;

                        }
                    }
                    if (cnt > 1)
                    {
                        Console.WriteLine(Arr[i] + "  times   " + cnt);
                    }

                }
            }

        }

    }
}

