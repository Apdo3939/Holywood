using System;
using Holywood.dominio;


namespace Holywood
{
    class Tela
    {
        public static void Menu()
        {
            Console.WriteLine("\t1 – Listar artistas ordenadamente");
            Console.WriteLine("\t2 – Cadastrar artista");
            Console.WriteLine("\t3 – Cadastrar filme");
            Console.WriteLine("\t4 – Mostrar dados de um filme");
            Console.WriteLine("\t5 – Sair");
        }

        public static void CadastrarArtistas()
        {
            Console.WriteLine("\tDigite os dados do artista: ");
            Console.Write("\tCódigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("\tNome: ");
            string nome = Console.ReadLine();
            Console.Write("\tValor do cachê: ");
            double cache = double.Parse(Console.ReadLine());
            Artista art = new Artista(codigo, nome, cache);
            
        }
    }
}
