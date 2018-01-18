using System.Globalization;
using System;

namespace Holywood.dominio
{
    class Artista : IComparable
    {
        //atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

        //construtor
        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;

        }
        public override string ToString()
        {
            return  "\t"
                + codigo
                + ", "
                + nome
                + ", Cachê: "
                + cache.ToString("F2", CultureInfo.InvariantCulture); 
        }

        public int CompareTo(object obj)
        {
            Artista outro = (Artista)obj;
            return nome.CompareTo(outro.nome);
            //throw new NotImplementedException();
        }
    }//classe Pronta
}
