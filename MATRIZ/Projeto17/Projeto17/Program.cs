using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamano da matriz?   ");
            string t =  Console.ReadLine();
            string[] tamanho = t.Split(" ");

            int linha = int.Parse(tamanho[0]);
            int coluna = int.Parse(tamanho[1]);

            Console.WriteLine($"Matriz: {linha} X {coluna}");

            int[,] matr = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++)
                {
                    matr[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Dite um numero: ");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine();
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (num == matr[i,j])
                    {
                        Console.WriteLine("Posição: " + i +","+ j );
                        if (j < coluna - 1)
                        {
                            Console.WriteLine("Direita: " + matr[i, j + 1]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matr[i, j - 1]);
                        }
                        if (i < linha - 1)
                        {
                            Console.WriteLine("Baixo: " + matr[i+1, j]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + matr[i-1, j]);
                        }
                        
                    }
                }
            }
           
        }
    }
}