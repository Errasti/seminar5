int[] CreateArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-99,100);
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

int FindNegPosSum(int[] array)
{
    int summ = 0;
    for( int i = 0; i < array.Length; i++ )
    {
        if( i % 2 == 1 )
        {
            summ += array[i];
        }
    }
    return summ;
}

Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] arr = CreateArray(len);
ShowArray(arr);

Console.WriteLine(FindNegPosSum(arr));

