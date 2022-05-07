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
