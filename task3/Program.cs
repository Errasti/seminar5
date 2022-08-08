bool Contains(int[] arr, int n)
{
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == n)
        {
            return true;
        }
    }
    return false;
}

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] arr = GetArray(len);

Console.WriteLine("Введите нужное значение: ");
int number = int.Parse(Console.ReadLine());

PrintArray(arr);
/*for(int i = 0; i<arr.Length; i++)
{
    if (arr[i] == number)
    {
        Console.WriteLine("да");
    }
}
*/

if ( Contains(arr,number) == true )
{
    Console.WriteLine("Да это число есть в массиве");
}
else
{
    Console.WriteLine("Нет, этого числа нет в массиве");
}
