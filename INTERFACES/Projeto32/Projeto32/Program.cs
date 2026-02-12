using Projeto32.Entities;
using Projeto32.Service;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AreaCalculavel[] areas = new AreaCalculavel[5];

            for(int i=0; i < areas.Length; i++)
            {
                Console.Write("1- Circulo\n2- Retangulo\n3-Quadrado\nOpção:__");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (op == 1)
                {
                    Console.WriteLine(" Raio cÍrculo: ");
                    double raio = double.Parse(Console.ReadLine());

                    Circulo circulo = new Circulo(raio);
                    areas[i] = circulo;
                }

                if (op == 2)
                {
                    Console.WriteLine(" Base retangulo: ");
                    double basee = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Altura retangulo: ");
                    double altura = double.Parse(Console.ReadLine());

                    Retangulo retangulo = new Retangulo(basee, altura);
                    areas[i] = retangulo;
                }

                if (op == 3)
                {
                    Console.WriteLine(" Lado quadrado: ");
                    double lado = double.Parse(Console.ReadLine());

                    Quadrado quadrado = new Quadrado(lado);
                    areas[i] = quadrado;
                }

            }
            Console.WriteLine();
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Área do objeto {i + 1}: {areas[i].CalcularArea()}");
            }
        }
    }
}