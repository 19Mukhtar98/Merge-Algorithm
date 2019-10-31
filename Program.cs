using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeAlg
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = {32,45,12,21,10,8,5,77,93,97 };
            int n = 10;
            int i;
            Console.WriteLine("Merge Sorting");
            Console.Write("Verilmish ilkin array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            mergeSort(arr, 0, n - 1);
            Console.Write("\nSorting edilmish array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
        static public void merge(int[] arr, int lft, int mid, int rght)
        {
            int i, j, k;
            int n1 = mid - lft + 1;
            int n2 = rght - mid;
            int[] Larr= new int[n1];
            int[] Rarr = new int[n2];
            for (i = 0; i < n1; i++)
            {
                Larr[i] = arr[lft + i];
            }
            for (j = 0; j < n2; j++)
            {
                Rarr[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = lft;
            while (i < n1 && j < n2)
            {
                if (Larr[i] <= Rarr[j])
                {
                    arr[k] = Larr[i];
                    i++;
                }
                else
                {
                    arr[k] = Rarr[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = Larr[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = Rarr[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int lft, int rght)
        {
            if (lft < rght)
            {
                int mid = (lft + rght) / 2;
                mergeSort(arr, lft, mid);
                mergeSort(arr, mid + 1, rght);
                merge(arr, lft, mid, rght);
            }
        }


    }
}
