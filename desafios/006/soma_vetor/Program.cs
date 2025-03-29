int qtN;
double n, soma, media;

Console.Write("quantos numeros voce vai digitar? ");
qtN = int.Parse(Console.ReadLine());

double[] vet = new double[qtN];

for(int i = 0; i < qtN; i++) {
    Console.Write("digite um numero: ");
    vet[i] = double.Parse(Console.ReadLine());

}

Console.WriteLine();
Console.Write("VALORES = " );
for (int i = 0; i < qtN; i++) {
    Console.Write(vet[i] + " ");
}

Console.WriteLine();

soma = 0;
for(int i = 0; i < qtN; i++) {
    soma = soma + vet[i];
}

Console.WriteLine("SOMA = " + soma.ToString("F2"));

media = soma / qtN;

Console.WriteLine("MEDIA = " + media.ToString("F2"));