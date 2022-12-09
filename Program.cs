
using System;

class Pogram
{


    public static int[] sortArrays(int[] arr)
    {


        int length = arr.Length;


        for (int j = 0; j < length - 1; j++)
        {


            if (arr[j] > arr[j + 1])
            {


                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;


                j = -1;
            }
        }
        return arr;
    }


    public static void Main(String[] args)
    {

        int[] arr = { 1, 2, 150, 9, 8,
                    7, 6, 0, 5, 4, 3 };




        arr = sortArrays(arr);


        Console.WriteLine("new array: " +
                        String.Join(", ", arr));
    }
}


