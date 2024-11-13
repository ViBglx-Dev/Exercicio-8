namespace Exercicio_8.Models
{
    public class Televisor : Eletrodomesticos
    {
        public int TamanhoTela { get; set; }
        public bool Ehsmart { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Consumo: {consumoEnergia}, Tamanho: {TamanhoTela}, É smart: {(Ehsmart ? "Sim" : "Não")}";
        }
    }
}
