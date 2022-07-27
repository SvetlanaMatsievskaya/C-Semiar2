int SecondDigitFrom3(int temp)
{
               
        return temp%100/10;
}
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(SecondDigitFrom3(a));