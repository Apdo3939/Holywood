using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holywood.dominio
{
    class Filme
    {
        //atributos
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }

        //Construtor
        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
        }

        //metodos
        public override string ToString()
        {
            string s = "\tFilme"
                + codigo
                + ", Título: "
                + titulo
                + ", Ano: "
                + ano
                + "\n"
                + "\tParticipações:\n";
            return s;


        }

        public double Custo()
        {
            return 0;
        }
    }
}
