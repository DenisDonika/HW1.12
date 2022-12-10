//Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("input 8 numbers");
void FillArray(int[] array)
{
    int length = 8;
    int index = 0;
    while (index < length)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
Console.Write($"{FillArray}");