//Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");
//for (int i = num; i >= 1; i--) Console.Write($"{Math.Pow(i, 3)}, "); // в обратном порядке 
//Console.Write(" ");

//3 -> [1, 8, 27].
//5 -> [1, 8, 27, 64, 125]
