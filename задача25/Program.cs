/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int getThirdDegree(int number,int degree)
{
    int res=1;
    for (int i = 1; i <=degree; i++)
    {
        res*=number;
    }
    return res;
}
Console.WriteLine("введите число");
int userNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень");
int userDegree=Convert.ToInt32(Console.ReadLine());

int ansver=getThirdDegree(userNumber,userDegree);
Console.WriteLine($"число {userNumber} в степени {userDegree} равно {ansver}");