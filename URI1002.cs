using System.Globalization;
double area, raio, n = 3.14159;

raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = (n * (raio * raio));

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
