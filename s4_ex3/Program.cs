void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


Console.WriteLine("Введите числа через запятую ");

int[] mass = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

Console.Write("Ваш массив: ");


PrintArray(mass);
