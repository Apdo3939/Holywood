using System;
using System.Collections.Generic;
using Holywood.dominio;

namespace Holywood
{
    class Program
    {
        static List<Artista> artista = new List<Artista>();
        static List<Filme> filmes = new List<Filme>();

        static void Main(string[] args)
        {
            //variaveis
            int opcao = 0;
            
            //entradas
            artista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artista.Add(new Artista(102, "Chris Evans       ", 2500000.00));
            artista.Add(new Artista(103, "Robert Downey Jr. ", 3000000.00));
            artista.Add(new Artista(104, "Morgan Freeman    ", 4000000.00));

            //loop principal do programa
            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t--------------------------------------------------------------");
                Console.WriteLine("\t------------------- Artistas de Holywood ---------------------");
                Console.WriteLine("\t--------------------------------------------------------------");
                Console.WriteLine();

                Tela.Menu();
                Console.WriteLine();

                Console.Write("\tPor favor Digite uma opção acima: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("\tLISTAGEM DE ARTISTAS:");
                        for (int i = 0; i < artista.Count; i++)
                        {
                            Console.WriteLine("\t" + artista[i]);
                        }
                        break;

                    case 2:
                        Console.WriteLine();
                        Tela.CadastrarArtistas();
                        //parado aqui, tentando solucionar a questão list para cadastro de artista
                        
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
