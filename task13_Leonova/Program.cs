// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число");
int Num1 = Convert.ToInt32(Console.ReadLine());
string stringnum = Num1.ToString();

if (Num1 < 99)
 {
     Console.WriteLine("третья цифра отсутствует");
 }
   
else 
{
  Console.WriteLine(stringnum[2]);
}
    