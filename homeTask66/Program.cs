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
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int RecMN(int M, int N, int sum = 0)
{
    if (M >= N) return sum + N;
     sum = M + RecMN(M + 1, N);
    return sum;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
if (number1 > number2)
{
    int swap = number1;
    number1 = number2;
    number2 = swap;
}
PrintResult(RecMN(number1,number2));