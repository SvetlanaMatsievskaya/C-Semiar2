int Third_Digit_From_Over100(int t2)
{
    while (t2>=1000)
    {
        t2 = t2/10;
     }
    t2 = t2%10; 
    return t2;
}
int number = 0;
Console.WriteLine("Введите число: ");

number = int.Parse(Console.ReadLine());
if (number<100)
{
    Console.WriteLine("Нет третьей цифры");
}
else if (number>=100)
{
    int m = Third_Digit_From_Over100(number);
    Console.WriteLine(m);
}
    

