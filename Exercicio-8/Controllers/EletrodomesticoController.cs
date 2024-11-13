using Exercicio_8.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio_8.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomesticos> eletrodomestico = new List<Eletrodomesticos>
            {
                new Geladeira {marca = "Brastemp", modelo = "Frost Free", consumoEnergia = 60, capacidade = 418, temFreezer = true },
                new Geladeira {marca = "Electrolux", modelo = "Inverter", consumoEnergia = 27, capacidade = 278, temFreezer = false },
                new Televisor {marca = "Philco", modelo = "LED DOLLBY", consumoEnergia = 49, TamanhoTela = 43, Ehsmart = true }
            };
            return View(eletrodomestico);
        }
    }
}
