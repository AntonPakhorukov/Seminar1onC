/* 
Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.Clear();
Console.Write("Введите трех значное число: ");
int number = int.Parse(Console.ReadLine());
if (number / 100 < 1) {
    Console.WriteLine("Вы ввели не трех значное число");
    return;
} else if (number / 100 > 10) {
    Console.WriteLine("Вы ввели не трех значное число");
    return;
}
Console.WriteLine(number % 10);