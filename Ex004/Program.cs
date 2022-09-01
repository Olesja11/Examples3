// Напишите программу, которая на вход принимает радиус круга
//и находит его площадь округленную до целого числа,
// необходимо вывести максимальную цифру в полученном
// округлённом значении площади круга

Console.Clear();
Console.WriteLine("Введи радиус круга");
int radius = int.Parse (Console.ReadLine());
double S = Math.Round(Math.Pow(radius,2) * Math.PI);
double  max = 1;  
 while (S>0)
 {
    double i = S % 10;
    S = S / 10;
    if (i > max)
    {
        max = i;
        }

 }
Console.WriteLine(max);
