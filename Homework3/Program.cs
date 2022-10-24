//Задача 19 Напишите программу, которая принимает на вход любое int число и проверяет, является ли оно палиндромом.

void Palindrome(int number)
{
    int newNum = 0;
    int oldNum = number;
    while (oldNum > 0)
    {
        int dig = oldNum % 10;
        newNum = newNum * 10 + dig;
        oldNum = oldNum / 10;
    }

   if (number == newNum) Console.WriteLine($"{number} is a Palindrome");
   else Console.WriteLine($"{number} is not a Palindrome");

}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrome(num);


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.Write("Input x of first point: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y of first point: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z of first point: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x of second point: ");
double num4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y of second point: ");
double num5 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z of second point: ");
double num6 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"3D Distance is {Distance(num1, num2, num3, num4, num5, num6)}");*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubTable(int cubNumber)
{
    for (int i = 1; i <= cubNumber; i++)
    {
       Console.Write(Math.Pow(i, 3) + " ");
    }
    
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubTable(number);*/

