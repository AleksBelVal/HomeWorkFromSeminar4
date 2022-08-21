// Задача 27: Программа принимает на вход число
// выдаёт сумму цифр в числе.

Console.Write("Введите число, содержащее не более 5 цифр: ");
int numA = Convert.ToInt32(Console.ReadLine());

int num1 = numA / 1 % 10;
int num2 = numA / 10 % 10;
int num3 = numA / 100 % 10;
int num4 = numA / 1000 % 10;
int num5 = numA / 10000 % 10;

int result = num1 + num2 + num3 + num4 + num5;
 
Console.WriteLine($"Сумма цифр = {result}");