int SecondDigitFrom3(int temp)
{
               
        return temp%100/10;
}
Console.Write("Введите трехзначное число: ");

int a = int.Parse(Console.ReadLine());
if (a < 100 || a > 999)
{
        Console.WriteLine("Вы ввели число неправильно");        
}
else
{
        Console.WriteLine(SecondDigitFrom3(a));
}
