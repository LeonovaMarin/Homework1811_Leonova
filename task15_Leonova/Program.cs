// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


Console.WriteLine("Введите день недели числом от 1 до 7");
int Num1 = Convert.ToInt32(Console.ReadLine());

if (Num1 == 1)
    Console.Write("рабочий день");
if (Num1 == 2)
    Console.Write("рабочий день");
if (Num1 == 3)
    Console.Write("рабочий день");
if (Num1 == 4)
    Console.Write("рабочий день");
if (Num1 == 5)
    Console.Write("рабочий день");
 if (Num1 == 6)
    Console.Write("выходной день");
if (Num1 == 7)
    Console.Write("выходной день");
if (Num1 < 1)
    Console.Write("введите другое значение");
 if (Num1 > 7 )
    Console.Write("введите другое значение");