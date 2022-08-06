Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfDigit(int n)
{
int sum = 0;
while (n > 0 )
{
   sum = sum + n%10;
   n = n/10;
}
return sum;
}

int digit = SumOfDigit(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {digit}");
