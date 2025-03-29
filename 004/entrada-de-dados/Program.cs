using System.Globalization; 

CultureInfo CI = CultureInfo.InvariantCulture; 
string nome1, nome2;
double salario1, salario2;
int idade;
char sexo;

Console.Write("nome da primeira pessoa: ");
nome1 = Console.ReadLine();
Console.Write("salario da primeira pessoa: ");
salario1 = double.Parse(Console.ReadLine(), CI);

Console.Write("nome da segunda pessoa: ");
nome2 = Console.ReadLine();
Console.Write("salario da segunda pessoa: ");
salario2 = double.Parse(Console.ReadLine(), CI);

Console.Write("digite uma idade: ");
idade = int.Parse(Console.ReadLine());
Console.Write("digite um sexo (F/M): ");
sexo = char.Parse(Console.ReadLine());

 Console.WriteLine("Nome 1: " + nome1); 
Console.WriteLine("Salario 1: " + salario1.ToString("F2"), CI);  
Console.WriteLine("Nome 2: " + nome2); 
Console.WriteLine("Salario 2: " + salario2.ToString("F2"), CI); 
Console.WriteLine("Idade: " + idade); 
Console.WriteLine("Sexo: " + sexo);