public class bubblesort
{
    public static void bubble_sort(int[] list, int list_length) //implementation of the bubble sort algorithm
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

    public static void main(String[] args) //main function that runs when the program starts
    {
        int[] list = { 10, 5, 3, 2, 4, 6, 7, 9, 8, 1};
        bubble_sort(list, 10);
        for (int i = 0; i < 10; i++)
        {
            System.out.println(list[i]);
        }
    }
}