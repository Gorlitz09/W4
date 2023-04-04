/*Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/

Console.Clear();
int[] num = new int[8];
Console.Write("[");
for (int i = 0; i < num.Length; i++)
{
    num [i] = new Random().Next(0, 100);
    Console.Write(" " + Met (i) + " ");
}
Console.Write("]");
int Met (int a)
{
    return num[a];
}