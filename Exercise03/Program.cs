void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arraySort)
{
    int length = arraySort.Length;
    for (int i = 0; i < length - 1; i++)
    {
        int minPosition = i;
        
        for(int j = i + 1; j < length; j++)
        {
            if (arraySort[j] < arraySort[minPosition])
                minPosition = j;
        }

        int temporary = arraySort[i];
        arraySort[i] = arraySort[minPosition];
        arraySort[minPosition] = temporary;
    }
}

int[] arrayNumbers = { 6, 8, 3, 2, 1, 4, 5, 7, 9, 1, 6, 4, 3 };
PrintArray(arrayNumbers);
SelectionSort(arrayNumbers);
PrintArray(arrayNumbers);