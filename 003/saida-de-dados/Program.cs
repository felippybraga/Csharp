// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Write("Bom dia"); 
Console.Write("Boa noite"); 

Console.WriteLine("\nBom dia"); 
Console.WriteLine("Boa noite"); 

int x, y; 
x = 10; 
y = 20; 
Console.WriteLine(x); 
Console.WriteLine(y);

double z; 
z = 2.3456; 
Console.WriteLine(z.ToString("F2"));

CultureInfo CI = CultureInfo.InvariantCulture; 
 
int idade; 
double salario; 
string nome; 
char sexo; 
 
idade = 32; 
salario = 4560.9; 
nome = "Maria Silva"; 
sexo = 'F'; 
 
Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo + ", ganha " +salario.ToString("F2", CI) + " e tem " + idade + " anos");