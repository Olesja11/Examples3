// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введи N");
int N = int.Parse (Console.ReadLine());
int i = 1;
while (i<N+1) 
{
    double cube_i = Math.Pow(i,3);
    Console.Write($"{cube_i}, ");
    i++;
}