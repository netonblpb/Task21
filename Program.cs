// Программа проверяет пятизначное число на палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length != 5) Console.WriteLine("Неправильное число!");

else if (number[0] == number [4] && number[1] == number[3]) Console.WriteLine("введенное число - палиндром");

else Console.WriteLine("Ввведенное число - не палиндром");