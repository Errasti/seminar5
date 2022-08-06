int[] getArray(int n)
{
    int [] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i]=rnd.Next(-9,10);
    }
    return arr;
}

int[] array = getArray(12);
int sumLess = 0;
int sumGreat = 0;
for ( int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumGreat += array[i];
    }
    else
    {
        sumLess += array[i];
    }
}

Console.WriteLine("Сумма положительных - " + sumGreat + ", а сумма отрицательных - " + sumLess);
