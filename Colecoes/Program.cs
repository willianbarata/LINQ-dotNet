// See https://aka.ms/new-console-template for more information


using Colecoes.Helper;

OperacoesArray op = new OperacoesArray();

int[] array = new int[5] {6, 3 ,8 ,1, 9};
int[] arrayCopia = new int[10];

int valorProcurado = 1;

bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

if (todosMaiorQue)
{
    Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
}
else
{
    Console.WriteLine("Existe valores que não são maiores do que {0}",valorProcurado);
}

//bool existe = op.Existe(array, valorProcurado);

//if (existe)
//{
//    Console.WriteLine("Encontrei o Valor {0}", valorProcurado);
//}
//else
//{
//    Console.WriteLine("Não encontrei o Valor: {0}", valorProcurado);
//}

//Console.WriteLine("Array Sem ordenação");
//op.ImprimirArray(array);

//Console.WriteLine("Array ordenado");
//op.OrdenarBubbleSort(ref array);
//op.Ordenar(ref array);


//op.ImprimirArray(array);

//Console.WriteLine("Array antes da cópia");
//op.ImprimirArray(arrayCopia);

//op.Copiar(ref array, ref arrayCopia);
//op.ImprimirArray(arrayCopia);

//int[] arrayInteiros = new int[3];

//arrayInteiros[0] = 1;
//arrayInteiros[1] = 2;
//arrayInteiros[2] = 3;

//Console.WriteLine("Percorrendo Array pelo For");
//for(int i = 0; i < arrayInteiros.Length; i++)
//{
//    Console.WriteLine(arrayInteiros[i]);
//}

//Console.WriteLine("Percorrendo Array pelo Foreach");
//foreach (int i in arrayInteiros)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Impressão da Matriz");

//int[,] matriz = new int[4, 2]
//{
//    { 1 ,100 },    
//    { 2 ,200 },  
//    { 3 ,300 },  
//    { 4 ,400 }
//};

//for(int i = 0;i < matriz.GetLength(0); i++)
//{
//    for(int j = 0;j < matriz.GetLength(1); j++)
//    {
//        Console.WriteLine(matriz[i, j]);
//    }

//}