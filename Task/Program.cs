var rnd = new Random();

void Main()
{
    /* Задача 1
    Задайте значения M и N. Напишите
    программу, которая выведет все натуральные числа
    в промежутке от M до N. Использовать рекурсию, не
    использовать циклы.
    */


    int M = ReadInt("Введите число M:");
    int N = ReadInt("Введите число N:");

    int leftRange = M;
    int rightRange = N;
    if (N < M)
    {
        leftRange = N;
        rightRange = M;
    }

    PrintAllNumbers(leftRange, rightRange);
    


    System.Console.WriteLine();



    /* Задача 2
    Напишите программу вычисления функции
    Аккермана с помощью рекурсии. Даны два
    неотрицательных числа m и n.
    */
    System.Console.WriteLine("Функция Аккермана");


    ulong m = ReadUInt64("Введите число m: ");
    ulong n = ReadUInt64("Введите число n: ");

    Console.WriteLine($"Ответ: {AkkermanFunction(m, n)}");



    System.Console.WriteLine();



    /* Задача 3
    Задайте произвольный массив. Выведете
    его элементы, начиная с конца. Использовать
    рекурсию, не использовать циклы.
    */

    int[] array = MakeArrayRnd();
    PrintArray(array);
    System.Console.WriteLine();
    PrintArrayReverseRec(array);
}


Main();




//
int ReadInt(string msg = "Введите число:")
{
    Console.Write($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}



//
ulong ReadUInt64(string msg = "Введите число:")
{
    Console.Write($"{msg} ");
    return Convert.ToUInt64(Console.ReadLine());
}





// Функция для 1-ой задачи
void PrintAllNumbers(int leftRange, int rightRange)
    {
        if (leftRange > rightRange) return;
        Console.Write($"{leftRange} ");
        PrintAllNumbers(leftRange + 1, rightRange);
    }







// Функция для 2-ой задачи
ulong AkkermanFunction(ulong m, ulong n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    else return 0;
}






// Функции для 3-ей задачи
int[] MakeArrayRnd(string lengthMsg = "Введите длину массива:", string minRangeMsg = "Введите минимальное число массива:",
                 string maxRangeMsg = "Введите максимальное число массива:")
{
    int arrLength = ReadInt(lengthMsg);
    int minRange = ReadInt(minRangeMsg);
    int maxRange = ReadInt(maxRangeMsg);
    int[] arr = new int[arrLength];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minRange, maxRange + 1);
    }
    return arr;
} 


void PrintArray(int[] arr, string msg = "Ваш массив:")
{
    System.Console.WriteLine(msg);
    System.Console.WriteLine($"[{string.Join(", ", arr)}]");
}


void PrintArrayReverseRec(int[] arr, int index = 0, string msg = "Массив после рекурсии: ")
{
    if (index >= arr.Length)
    {
        System.Console.WriteLine(msg);
        return;
    }
    PrintArrayReverseRec(arr, index + 1);
    System.Console.Write($"{arr[index]} ");
}
///