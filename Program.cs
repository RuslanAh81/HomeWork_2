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

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

 Console.WriteLine("Введите Ваше число ");
int  num = Convert.ToInt32(Console.ReadLine());
 int ThirdDigit( int a)
  {
    int result;
    if (num <100)
    
      result = 0;
    else
    {
    while(num > 1000)
      
      num = num /10;
      result = num % 10;
    }
  return result;
 }
  int third = ThirdDigit(num);
if (third > 0)  
  Console.WriteLine( "третья цифра " + third); 

else 
  Console.WriteLine( "В вашем числе нет третьей цифры " ); 

  

  // напишите программу, которая принимает на вход цифру, обозначающую день недели, и  проверяет, является ли этот день выходным.
/*
  bool FindVihodnoy(int cur)
  {
   bool result;
    if (cur >5)
    result = true;
    
        else 
   result= false;
    return result;
  }

  Console.WriteLine("Введите цифру дня недели : ");

  int cur = Convert.ToInt32(Console.ReadLine());

  bool Findvih = FindVihodnoy(cur);

 if (Findvih)

  Console.WriteLine("Выходной!!");

else

  Console.WriteLine("Рабочий");
  */