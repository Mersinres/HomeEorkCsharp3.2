// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.



Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число вляется палиндромом");
    }
    else
    {
        Console.WriteLine("Число Не вляется палиндромом");
    }
}
else
{
    Console.WriteLine("!!!Попробуй снова, число больше или меньше пяти !!!");
}