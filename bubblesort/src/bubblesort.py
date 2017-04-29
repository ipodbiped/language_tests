def bubble_sort(list_, list_length):
    temp_store = 0
    for counter in range(0, list_length - 1):
        for iterator in range(0, list_length - 1):
            if list_[iterator] > list_[iterator + 1]:
                temp_store = list_[iterator]
                list_[iterator] = list_[iterator + 1]
                list_[iterator + 1] = temp_store
    return list_

def main():
    list_ = [10, 5, 3, 2, 4, 6, 7, 9, 8, 1];
    list_sorted = bubble_sort(list_, 10)
    for counter in range(0, 10):
        print(list_sorted[counter])

if __name__ == "__main__":
    main()
    
