//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void SumMN(int M, int N, int sum)
{
     sum = sum + N;
     if (N <= M)
    {
         Console.Write($" {sum} ");
         return;
     }
     SumMN(M, N - 1, sum);
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int sum = 0;
if (number1 < number2)
{
    int t = number1;
    number1 = number2;
    number2 = t;
}
SumMN(number1, number2, sum);
