//программа принимает число N, выдает произведение от 1 до N
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение цифр = {GetCompNums(num)}");

int GetCompNums(int number)
{
    int comp = 1;
    while(number > 1)
    {
        comp *= number;
        number--;
        Console.Write($"{comp} ");
    }
    Console.WriteLine();
    return comp;
}