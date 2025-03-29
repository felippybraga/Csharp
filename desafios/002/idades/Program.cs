string nome1, nome2;
int idade1, idade2;
double media;

Console.WriteLine("Dados da primeira pessoa: ");

Console.Write("nome: ");
nome1 = Console.ReadLine();

Console.Write("idade: ");
idade1 = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");

Console.Write("nome: ");
nome2 = Console.ReadLine();

Console.Write("idade: ");
idade2 = int.Parse(Console.ReadLine());

media = ((double)idade1 + idade2) / 2;
Console.WriteLine("A idade media da " + nome1 + " e " + nome2 + " eh de " + media + " anos");


