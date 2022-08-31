//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введи число");
int chislo = int.Parse (Console.ReadLine());
int numA = chislo/1000;
int numB = chislo%10*10 + chislo%100/10;
if (numA == numB) 
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}