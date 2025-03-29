using System.Runtime.InteropServices;

int n1, n2, troca, soma;

Console.WriteLine("digite dois numeros: ");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

if(n1 > n2) {
    troca = n1;
    n1 = n2;
    n2 = troca;
} 

soma = 0;
for(int i = n1+1; i < n2; i++) {
    if(i % 2 != 0) {
        soma = soma + i;
    }
}

Console.WriteLine($"A SOMA DOS IMPARES = {soma}");