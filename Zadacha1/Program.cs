/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */



Console.Write("Введите трёхзначное число: ");

int threedigit_number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threedigit_number);

Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

