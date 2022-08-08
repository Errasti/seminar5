int[] CreateArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1,1000);
    }
    return arr;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int DigitCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] arr = CreateArray(len);

ShowArray(arr);

Console.WriteLine(DigitCount(arr));

