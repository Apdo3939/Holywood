using System.Globalization;

namespace Holywood.dominio
{
    class Participacao
    {
        //atributos
        public double desconto { get; set; }
        public Artista a { get; set; }
        public Filme f { get; set; }
        
        //Construtor
        public Participacao(double desconto, Artista a, Filme f)
        {
            this.desconto = desconto;
            this.a = a;
            this.f = f;
        }

        //To string
        public override string ToString()
        {
            return "\t"
                +  a.nome
                + ", Cachê: "
                + a.cache
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + Custo().ToString("F2", CultureInfo.InvariantCulture);
        }

        //metodo
        public double Custo()
        {
            return a.cache - desconto;
        }

    }//classe Pronta
}
