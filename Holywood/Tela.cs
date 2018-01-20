using System;
using System.Globalization;
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

        public static void ListarArtitas() // opção 1
        {
            Console.WriteLine("\tLISTAGEM DE ARTISTAS:");

            for (int i = 0; i < Program.artista.Count; i++)
            {
                Console.WriteLine("\t" + Program.artista[i]);
            }
        }

        public static void CadastrarArtistas() // opção 2
        {
            Console.WriteLine("\tDigite os dados do artista: ");
            Console.Write("\tCódigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("\tNome: ");
            string nome = Console.ReadLine();
            Console.Write("\tValor do cachê: ");
            double cache = double.Parse(Console.ReadLine());
            Artista art = new Artista(codigo, nome, cache);
            Program.artista.Add(art);
            Program.artista.Sort();
            
        }

        public static void CadastrarFilme() // opção 3
        {
            //entradas instaciando o objeto Filme
            Console.WriteLine("\tDigite os dados do filme:  ");
            Console.Write("\tCódigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("\tTítulo: ");
            string titulo = Console.ReadLine();
            Console.Write("\tAno: ");
            int ano = int.Parse(Console.ReadLine());
            Filme F = new Filme(codigo, titulo, ano);

           
            Console.Write("\tQuantas participações tem o filme? ");
            int n = int.Parse(Console.ReadLine());
            //loop para ler a lista
            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine("\tDigite os dados da " + i + " participação:");
                Console.Write("\tArtista (código): ");
                int artCod = int.Parse(Console.ReadLine());

                //criando uma variavel para comparar entrada de usuário x lista artistas
                int pos = Program.artista.FindIndex(x => x.codigo == artCod);
                //menos um retorna não achado o artcod digitado pelo usuário
                if (pos == -1)
                {
                    throw new ModelException("Código de artista não encontrado: " + artCod);
                }
                
                //se artcod achado, continua o codigo
                Console.Write("\tDesconto: ");
                double desconto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Participacao part = new Participacao(desconto, Program.artista[pos], F);
                F.p.Add(part);
                }
            //adicionado a lista de filmes
            Program.filmes.Add(F);
        }
        public static void MostrarFilme()//opção 4
        {
            Console.Write("\tDigite o código do filme:  ");
            int codigoFilme = int.Parse(Console.ReadLine());
            
            //criando uma variavel para comparar entrada de usuário x lista fimes
            int pos = Program.filmes.FindIndex(x => x.codigo == codigoFilme);
            
            //menos um retorna não achado o codigofilme  digitado pelo usuário
            if (pos == -1)
            {
                throw new ModelException("Código de filme não encontrado: " + codigoFilme);
            }
            
            //se codigofilme achado, continua o codigo
            for (int i = 0; i < Program.filmes.Count; i ++)
            {
                Console.WriteLine("\t" + Program.filmes[i]);
            }
            
        }

    }
}
