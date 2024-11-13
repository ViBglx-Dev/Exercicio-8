namespace Exercicio_8.Models
{
    public class Geladeira : Eletrodomesticos
    {
        public int capacidade {  get; set; }
        public bool temFreezer { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Consumo: {consumoEnergia}, Capacidade: {capacidade}, Freezer: {(temFreezer ? "Sim" : "Não")}";
        }
    }
}
