using System;
using System.Collections.Generic;
using Holywood.dominio;

namespace Holywood
{
    class Program
    {
        public static List<Artista> artista = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();

        static void Main(string[] args)
        {
            //variaveis
            int opcao = 0;
            
            //entradas
            artista.Add(new Artista(101, "Scarlett Johansson" , 4000000.00));
            artista.Add(new Artista(102, "Chris Evans" , 2500000.00));
            artista.Add(new Artista(103, "Robert Downey Jr." , 3000000.00));
            artista.Add(new Artista(104, "Morgan Freeman" , 4000000.00));
            artista.Sort();
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
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\tErro Inesperado: " + e.Message);
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine();
                        Tela.ListarArtitas();
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine();
                            Tela.CadastrarArtistas();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\tErro Inesperado: " + e.Message);
                        }
                        
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine();
                            Tela.CadastrarFilme();
                        }
                        catch(ModelException e)
                        {
                            Console.WriteLine("\tErro de negócio: " + e.Message);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("\tErro Inesperado: " + e.Message);
                        }
                        
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine();
                            Tela.MostrarFilme();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("\tErro de negócio: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\tErro Inesperado: " + e.Message);
                        }
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("\tObrigado por usar este programa... " );
                        Console.WriteLine("\tAperte qualquer tecla para sair... ");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tOpção Invalida... ");
                        Console.WriteLine("\tAperte qualquer tecla para nova opções... ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
