using System.Globalization;
double n = 3.14159;
double area, raio;

raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = (n * Math.Pow(raio, 2.0));

Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
