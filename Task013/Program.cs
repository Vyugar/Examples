double[,] array = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array[i, j] = random.NextDouble() * 100; // TODO: Все дело в математике
        Console.Write(array[i, j].ToString("F3") + "\t");
    }
    Console.WriteLine();
}