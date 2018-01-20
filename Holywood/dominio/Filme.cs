using System.Globalization;
using System.Collections.Generic;

namespace Holywood.dominio
{
    class Filme
    {
        //atributos
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> p { get; set; }//colocar numa lista

        //Construtor
        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            p = new List<Participacao>();
        }

        //metodos
        public override string ToString()
        {
            string s = "Filme: "
                + codigo
                + ", Título: "
                + titulo
                + ", Ano: "
                + ano
                + "\n"
                + "\tParticipações:\n";
            
            //lendo a lista de participação
            for (int i = 0; i < p.Count; i++)
            {
                s = s  + p[i] + "\n";
            }
            s = s + "\tCusto total do filme: " + CustoTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }

        //metodo para calcular o Custo Total
        public double CustoTotal()
        {
            double soma = 0.00;
            for (int i = 0; i < p.Count; i++)
            { soma = soma + p[i].Custo(); }

            return soma;
        }
    }//classe Pronta
}
