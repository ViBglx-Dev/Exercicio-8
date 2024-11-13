namespace Exercicio_8.Models
{
    public abstract class Eletrodomesticos
    {
        public string marca {  get; set; }
        public string modelo { get; set; }
        public double consumoEnergia { get; set; }
        public abstract string ExibirDetalhes();
    }
}
