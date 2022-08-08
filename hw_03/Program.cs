double FindSubtraction(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] > max )
        {
            max = array[i];
        }
        else if ( array[i] < min )
        {
            min = array[i];
        }
    }
    double sub = max - min;
    return sub;
}

double[] CreateArray(int n)
{
    double[] arr = new double[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(-1000,999)/10.0);
    }
    return arr;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
double[] arr = CreateArray(len);
ShowArray(arr);

Console.WriteLine(FindSubtraction(arr));




