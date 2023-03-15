int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
     numbers[i] = rand.Next(1, 10);
     System.Console.Write(numbers[i] + ", ");
}
int kol(int[] numbers)
{
    int sum = 0;
    int i = 0;
    while (i < numbers.Length)
    {
        sum = sum + numbers[i];
        i = i + 2;
    }
    return sum;
}
Console.WriteLine(kol(numbers));