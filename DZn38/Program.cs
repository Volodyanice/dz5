int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    numbers[i] = rand.Next(1, 10);
    System.Console.Write(numbers[i] + ", ");
}
int raz(int[] numbers)
{
    int min = numbers[0];
    int max = numbers[0];
    int i = 1;
    while (i < numbers.Length)
    {
        if (max < numbers[i])
        {
            max = numbers[i];
        }
        if (min > numbers[i])
        {
            min = numbers[i];
        }
        i = i + 1;
    }
    return max-min;
}
System.Console.WriteLine(raz(numbers));