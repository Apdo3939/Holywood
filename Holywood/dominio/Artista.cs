using System.Globalization;


namespace Holywood.dominio
{
    class Artista
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
            return  codigo
                + ", \t"
                + nome
                + ", \t\tCachê: "
                + cache.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
