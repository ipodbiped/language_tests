function bubble_sort(list, list_length) //implementation of the bubble sort algorithm
{
    var temp_store;
        for (var i = 0; i < (list_length - 1); i++)
        {
            for (var j = 0; j < (list_length - 1); j++)
            {
                if (list[j] > list[j+1])
                {  
                    temp_store = list[j];
                    list[j] = list[j+1];
                    list[j+1] = temp_store;
                }
            }
        }
    return list;
}

list = [10, 5, 3, 2, 4, 6, 7, 9, 8, 1];
sorted_list = bubble_sort(list, 10);

for (i = 0; i < 10; i++) //prints out the sorted array
{
    console.log(sorted_list[i]);
}