/*
// напишите программу,которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число :");
int numb = Convert.ToInt32(Console.ReadLine());

int FindNumb2(int num)
{
    int des = num % 100;
    int ed = des / 10;
    return ed;
}
int res = FindNumb2(numb);
Console.Write( "Вторая цифра " +  res);

*/