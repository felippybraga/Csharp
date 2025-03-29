using System.Reflection;

int n1, n2;

Console.WriteLine("digite dois numeros");
n1= int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

while(n1 != n2) {
    if(n1 < n2) {
        Console.WriteLine("CRESCENTE!");

        Console.WriteLine("digite outros dois numeros");
        n1= int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
    } else {
        Console.WriteLine("DECRESCENTE!");

        Console.WriteLine("digite outros dois numeros");
        n1= int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
    }
}