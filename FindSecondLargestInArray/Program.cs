using System;
using System.ComponentModel.DataAnnotations;


class SecondLargestInArray
{
    public int SecondLarge(int[] arr)
    {
        int length = arr.Length;
        int largest = arr[0];
        int secondLargest = arr[1];

        for (int i = 0; i < length; i++)
        {
            if (arr[i] > largest)
            {
              secondLargest = largest;
              largest = arr[i];
            }
            if(i == length - 1 && arr[i] > secondLargest && arr[i] < largest)
            {
                
                secondLargest = arr[i];
            }
            
        }

        return secondLargest;
    }
    static void Main(string[] ag)
    {
        Console.WriteLine("Enter the no of elements in array");
        int lim = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[lim];
        Console.WriteLine("Enter the array values:");
        for (int i = 0; i < lim; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        SecondLargestInArray slg = new SecondLargestInArray();
        int secondLarge = slg.SecondLarge(arr);
        Console.WriteLine("The second largest element in arra is: "+secondLarge);

    }
}