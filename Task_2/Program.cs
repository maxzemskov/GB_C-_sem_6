﻿
Console.WriteLine("Введите точку b1");
double b1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите точку k1");
double k1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите точку b2");
double b2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите точку k2");
double k2 = Convert.ToDouble(Console.ReadLine());


double x = (b2 - b1)/(k1 - k2);

double y = k1 * x + b1;

Console.WriteLine($"({x}; {y})");
