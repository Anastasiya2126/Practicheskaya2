﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write("Введите число: ");

int digit_number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(digit_number);


if (stringNumber.Length > 2)
{

    Console.WriteLine("Третья цифра числа -> "+stringNumber[2]);

}
 
 else
 
     Console.WriteLine("Третьей цифры нет");
 


