//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Через строку решать нельзя.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = num%10;
while (num > 0) 
{
    num = num/10;
    sum = sum+num%10;
}

Console.WriteLine($"{sum}");
