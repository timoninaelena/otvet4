// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (number > 0)

{
    int count = number % 10;
    number = number / 10;
    sum = sum + count;
}
Console.WriteLine ($"Сумма цифр в числе: {sum}");

