//принимает число -> выводит кол-во цифр в нем
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = CountDig(num);

int CountDig(int number)
{
    int count = 0;
    while(number > 0)
    {
        number = number / 10;
        count++;
        Console.Write($"{number} ");
    }
    return count;
}
Console.WriteLine();
Console.WriteLine($"В числе {num} - {count} цифр");

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//int GetNum(int number)
//{
//    int count = 0;
//    while(number >= 1)
//    {
//          int num = number / 10;
//          number = num;
//          count++;
//    }
//    return count;
//}
//Console.WriteLine(GetNum(number));