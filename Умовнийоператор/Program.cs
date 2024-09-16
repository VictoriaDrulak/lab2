//завдання 1
{
       int x;
Console.WriteLine("введiть число");
x = int.Parse(Console.ReadLine());

if (x > 0)
{
    Console.WriteLine("число є додатнiм");
}
else if (x < 0)
{
    Console.WriteLine("число є вiд'ємним");
}
else
{
    Console.WriteLine("число дорiвнює нулю");
}
   }

//завдання 2
{
    int year;
    Console.WriteLine("введiть рiк");
    year = int.Parse(Console.ReadLine());

    if ((year % 4 == 0) & (year % 100 != 0))
    {
        Console.WriteLine("рiк високосний");
    }
    else if (year % 400 == 0)
    {
        Console.WriteLine("рiк високосний");
    }
    else
    {
        Console.WriteLine("рiк не високосний");
    }
}

//завдання 3
{
    int income;
    Console.Write("введiть дохiд:");
    income = int.Parse(Console.ReadLine());
    double tax = 0;

    if (income <= 10000)
    {
        tax = 0;
    }
    else if (income > 10000 && income <= 50000)
    {
        tax = (int)(income * 0.10);
    }
    else if (income > 50000 && income <= 100000)
    {
        tax = (int)(income * 0.20);
    }
    else if (income > 100000)
    {
        tax = (int)(income * 0.30);
    }

    Console.WriteLine($" податок на дохiд  {tax} грн.");
}

//завдання 4
{
    char symbol;
    Console.WriteLine("введiть лiтеру");
    symbol = char.Parse(Console.ReadLine());

    if ("aeiou".Contains(symbol))
    {
        Console.WriteLine($"{symbol} є голосною");
    }
    else if (char.IsLetter(symbol))
    {
        Console.WriteLine($"{symbol} є приголосною");
    }
    else
    {
        Console.WriteLine("введений символ не є лiтерою");
    }
}

//завдання 5
{
    Console.WriteLine("введiть перше число");
    double number_1;
    number_1 = double.Parse(Console.ReadLine());

    Console.WriteLine("введiть друге число");
    double number_2;
    number_2 = double.Parse(Console.ReadLine());

    Console.WriteLine("введiть третє число");
    double number_3;
    number_3 = double.Parse(Console.ReadLine());

    double max = number_1;

    if (number_2 > max)
    {
        max = number_2;
    }
    if (number_3 > max)
    {
        max = number_3;
    }
    Console.WriteLine($"найбiльше число: {max}");
}

//завдання 6 
{
    int age;
    Console.WriteLine("введiть вiк");
    age = int.Parse(Console.ReadLine());

    if (age >= 12)
    {
        Console.WriteLine($"вiк {age} є пiдлiтковим");
    }
    else if (age <= 18)
    {
        Console.WriteLine($"вiк {age} є пiдлiтковим");
    }
    else
    {
        Console.WriteLine($"вiк {age} не є пiдлiтковим");
    }
}
//завдання 7
{
    int number;
    Console.WriteLine("введiть число");
    number = int.Parse(Console.ReadLine());
    switch (number % 2)
    {
        case 0:
            Console.WriteLine($"{number} є парним.");
            break;
        case 1:
        case -1:
            Console.WriteLine($"{number} є непарним.");
            break;
    }

    switch (number % 3)
    {
        case 0:
            Console.WriteLine($"{number} дiлиться на 3.");
            break;
        default:
            Console.WriteLine($"{number} не дiлиться на 3.");
            break;
    }
}
// завдання 8
{
    Console.WriteLine("a");
    double a;
    a = double.Parse(Console.ReadLine());

    Console.WriteLine("b");
    double b;
    b = double.Parse(Console.ReadLine());

    Console.WriteLine("c");
    double c;
    c = double.Parse(Console.ReadLine());

    double max = a;

    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    Console.WriteLine($"найдовша сторона : {max}");
}