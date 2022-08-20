// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = ReadInt("Введите число: ");
int numB = ReadInt("Введите степень: ");

int sum = 1;

while(numB >=1)
{
    sum *= numA;
    numB--;
}

Console.WriteLine(sum);

