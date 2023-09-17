
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    Console.Write($"Enter number {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int SumFr1ToA(int nA)
{
    int temp = nA / 2;
    int sFr1ToA = (nA + 1) * temp;

    if (2 * temp < nA)
    {
        sFr1ToA = sFr1ToA + (temp + 1);
    }
    return sFr1ToA;
}

// int numA = GetNumber("A");
// int sum = SumFr1ToA(numA);
// System.Console.WriteLine($"sum = {sum}");
int num = 10;
int num2 = num++;// num2 = 10 ; num = (num)10 + 1 = 11

System.Console.WriteLine($" num = {num} ; num2 ={num2}");

int num3 = ++num;// num= (num)11 + 1 = 12; num3= (num)12
System.Console.WriteLine($" num = {num} ; num3 ={num3}");


int GetNumber(string message)
{
    Console.Write($"Enter number {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Getcount(int num)
{
int count = 0;
for (int i = 0; if < num; i++)
{
    count = count + 1;
}
return count;
}

GetNumber("X point");
//int result = Getcount("A");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message)
{
Console.WriteLine($"Enter number (message) : ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}
int GetCount(int num)
{
int count = 0;
for ( ; 0 < num; num /= 10)
{
count = count + 1;
}
return count;
}
int num = GetNumber("A");
int result = GetCount(num);
Console.WriteLine($"result = {result}");


// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string message)
{
Console.Write($"Введите целое число {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

long Composit(int num)
{
long comp = 1;
for (int i = 2; i <= num; i++)
{
comp = comp * i;
}
return comp;
}

int num = GetNumber("");
Console.WriteLine($"\nФакториал числа {num} равен {Composit(num)}.");

// Задержка экрана
Console.Write("\nДля продолжения нажмите любую клавишу..."); // "\n - "возврат каретки"
Console.Read();



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GetArray(int size, int min, int max)
{
int[] array = new int[size];
Random rand = new Random();

for (int i= 0 ; i < size; i++)
{
array[i] = rand.Next(min, max + 1);
}
return array;
}
void Print(int[]arr)
{
int length = arr.Length;
for (int i = 0; i < length; i++)
{
Console.Write($"{arr[i]} ");
}
}
Print(GetArray(8, 1, 1));


