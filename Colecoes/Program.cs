// See https://aka.ms/new-console-template for more information


int[] arrayInteiros = new int[3];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

Console.WriteLine("Percorrendo Array pelo For");
for(int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);
}

Console.WriteLine("Percorrendo Array pelo Foreach");
foreach (int i in arrayInteiros)
{
    Console.WriteLine(i);
}

Console.WriteLine("Impressão da Matriz");

int[,] matriz = new int[4, 2]
{
    { 1 ,100 },    
    { 2 ,200 },  
    { 3 ,300 },  
    { 4 ,400 }
};

for(int i = 0;i < matriz.GetLength(0); i++)
{
    for(int j = 0;j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j]);
    }
    
}