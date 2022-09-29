/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
int[] fillArray(int length,int minValue, int maxValue)
{
    int [] arr =new int [length];
    for (int i = 0; i <length; i++)
    {
        arr[i]=new Random().Next(minValue,maxValue+1);
    }
    return arr;
}
void printArray(int [] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length-1; i++)
    {
         Console.Write($"{massive[i]},");
    }
    Console.WriteLine($"{massive[massive.Length-1]}]");
}

Console.WriteLine("введите длину массива");
int lengthArray=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение чисел в массиве");
int userMinValue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите максимальное значение чисел в массиве");
int userMaxValue=Convert.ToInt32(Console.ReadLine());

printArray(fillArray(lengthArray,userMinValue,userMaxValue));


