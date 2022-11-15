//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input amount of the digits: ");
int amount = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < amount; i++)
{
    Console.WriteLine("Input a digit number " + (i+1));
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}

Console.WriteLine("Number of digit above 0 is " + count);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void LineCross(double k1, double b1, double k2, double b2){

    if(k1 == k2) Console.WriteLine("The lines are parallel");
    if (k1 == k2 && b1 == b2) Console.WriteLine("The lines are equal");
    if (k1 != k2 && b1 == b2) Console.WriteLine($"The intersection coordinates are ({0}; {b1})");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"The intersection coordinates are ({x}; {y})");
    }   
}

Console.Write("Input the first coefficient of the first line ");
double coef1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coefficient of the first line ");
double coef2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the first coefficient of the second line ");
double coef3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coefficient of the second line ");
double coef4 = Convert.ToDouble(Console.ReadLine());

LineCross(coef1,coef2,coef3,coef4);