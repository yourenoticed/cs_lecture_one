void SortArray (int[] array)
{
    int sorted = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - sorted - 1; j++)
        {
            
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
                
            }
        }
        sorted++;
    }
    
}

int[] CreateAndFillArrayWithRandomNums (int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray (int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void SortCreatedArrayAndShowTheResults (int size, int start, int end)
{
    int[] ints = CreateAndFillArrayWithRandomNums(size, start, end);
    PrintArray(ints);
    SortArray(ints);
    PrintArray(ints);
}

SortCreatedArrayAndShowTheResults(10, 1, 98);