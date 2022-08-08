// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// Console.Write("Введите число N: ");

int [] array = GitArray(8);
Console.Write($"[{String.Join(",", array)}]");
int[] GitArray(int size)
{
    int[] result = new int[size];
    for (int i=0; i< result.Length; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}
