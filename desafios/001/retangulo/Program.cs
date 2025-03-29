double baseR, altura, area, perimetro, diagonal;

Console.Write("base do retangulo: ");
baseR = double.Parse(Console.ReadLine());

Console.Write("altura do retangulo: ");
altura = double.Parse(Console.ReadLine());

area = baseR * altura;
perimetro = (baseR * 2) + (altura * 2); 
diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(altura, 2));

Console.WriteLine("AREA = " + area.ToString("F4"));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));