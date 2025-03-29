int n1, n2, n3;

Console.Write("Primeiro valor: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Segundo valor: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Terceiro valor: ");
n3 = int.Parse(Console.ReadLine());

if(n1 < n2 && n1 < n3) {
    Console.WriteLine("menor = " + n1);
} if(n2 < n3) {
    Console.WriteLine("menor = " + n2);
} else {
    Console.WriteLine("menor = " + n3);
}
