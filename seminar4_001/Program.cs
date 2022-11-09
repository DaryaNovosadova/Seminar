//принимает число (А), выводит сумму от 1 до А
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");


int GetSumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
        Console.Write($"{sum} ");
    }
    Console.WriteLine();
    return sum;
}