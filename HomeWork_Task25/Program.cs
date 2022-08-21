// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B (степень числа А): ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA;
for (int i = 1; i < numB; i++)
{
    result = result * numA;
}
Console.WriteLine($"Число {numA} в степени {numB} будет равно {result}");