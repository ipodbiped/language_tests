using System;

class bubblesort
{
    public static int[] list = { 10, 5, 3, 2, 4, 6, 7, 9, 8, 1}; //list to be sorted
    public static void bubble_sort(ref int[] list, int list_length) //function implementing the bubble sort algorithm
    {
        int temp_store;
        for (int i = 0; i < (list_length - 1); i++)
        {
            for (int j = 0; j < (list_length - 1); j++)
            {
                if (list[j] > list[j+1])
                {
                    temp_store = list[j];
                    list[j] = list[j+1];
                    list[j+1] = temp_store;
                }
            }
        }
    }

    static void Main(string [] args) //main function that runs when the program starts
    {
        bubblesort.bubble_sort(ref bubblesort.list, 10);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}", list[i]);
        }
    }
}