namespace PowerCalc { class Program { static void Main(string[] args) { Console.WriteLine(“Введите число A:”); int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(“\nВведите степень B:”);
int B = Convert.ToInt32(Console.ReadLine());

if (B == 0)
{
    Console.WriteLine($“A^B = 1 (A и B равны 0)”);
}
else
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    Console.WriteLine($“{A}^({B}) = {result}”);
}

Console.ReadKey();
}
}
}