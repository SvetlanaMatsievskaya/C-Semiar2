int CheckWeekday(int number)
{
    if (number > 0 && number < 8)
    {
        return number;
    }
    else
    {
        return -1;
    }    
    
}

void CheckWeekend(int number)
{
    if (number == -1 )
    {
        Console.Write("Неверно введено число");
    }
    
    else if (number > 0 && number < 6)
    {
        Console.Write("Нет");
    }
    else
    {
        Console.Write("Да");
    }
}
Console.Write("Введите число от 0 до 7: ");

int user = int.Parse(Console.ReadLine());
CheckWeekend(CheckWeekday(user));