int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
     numbers[i] = rand.Next(99, 999);
     System.Console.Write(numbers[i] + ", ");
}
int kol(int[] numbers)
{
    int kol = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            kol = kol + 1;
        }
    }
    return kol;
}

Console.WriteLine(kol(numbers));
