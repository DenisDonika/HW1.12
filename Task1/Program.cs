try
{
    Console.WriteLine("Введите 2 числа");
    double num1 = Convert.ToInt32(Console.ReadLine());
    double num2 = Convert.ToInt32(Console.ReadLine());

    
    double Sign(double a)
    {
        if (num2<0) num2 = num2*-1;
        for (int i = 1; i < num2; i++) a = a * num1;
        if (num2 == 0) a = 1;
        return a;
    }
    
    if (num2 < 0) Console.WriteLine($"1/{Sign}");

    Console.WriteLine($"{Sign(num1)}");
}

catch
{
    Console.WriteLine("Введите целое число цифрами");
}

