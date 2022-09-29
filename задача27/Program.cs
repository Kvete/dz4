/*
Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int getSummOfDigitalFromNunber(int number)
{
    int res=0;
    while (number>0)
    {
        res+=number%10;
        number=number/10;
    }
    return res;
}
Console.WriteLine("введите число");
int userNumber=Convert.ToInt32(Console.ReadLine());
int ansver=getSummOfDigitalFromNunber(userNumber);
Console.WriteLine($"сумма цифр в числе  {userNumber} равна {ansver}");