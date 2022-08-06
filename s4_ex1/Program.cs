Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ExpNumber(int a, int b)
{
int result = 1;
if ( b == 0) result = 1;
for (int i = 1; i<=b; i++)
    {
    result = result*a;
    }
return result;
}

int exponential = ExpNumber(num1, num2);
Console.WriteLine($"{num1} в степени {num2} равняется {exponential}");
