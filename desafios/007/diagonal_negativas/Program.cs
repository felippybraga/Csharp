int lc, negativos;

Console.Write("qual a ordem da matriz? ");
lc = int.Parse(Console.ReadLine());

int[,] mat = new int[lc, lc];

for(int i = 0; i < lc; i++) {
    for(int j = 0; j < lc; j++) {
        Console.Write($"elemento [{i}, {j}]: ");
        mat[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("DIAGONAL PRICIPAL: ");

for(int i = 0; i < lc; i++) {
    for(int j = 0; j < lc; j++) {
        if(i == j) {
            Console.Write(mat[i, j] + " ");
        }
    }
}

Console.WriteLine(" ");
negativos = 0;
for(int i = 0; i < lc; i++) {
    for(int j = 0; j < lc; j++) {
        if(mat[i, j] < 0) {
            negativos = negativos + 1;
        }
    }
}
Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativos);

