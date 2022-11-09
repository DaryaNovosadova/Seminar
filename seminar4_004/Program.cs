//массив из 8 элементов, заполненый нулями и единицами в случайном порядке [1,0,1,1,0,1,0,0]
//int[] array = new int[8];

//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = new Random().Next(0,2);
//    Console.Write($"{array[i]} ");
//}
//_________________________________________
//int[]array = new int[8];
//int[] NewArray(int[]ar)
//{
//    for(int i = 0; i < ar.Length; i++)
//    {
//        ar[i] = new Random().Next(0,2);
//        Console.Write($"{ar[i]} ");
//    }
//    return ar;
//}
//NewArray(array);
//________________________________________
void FillArray(int[] arr)
{
    int Length = arr.Length;
    for (int i = 0; i < Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    int Length = arr.Length;
    for (int i = 0; i < Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();