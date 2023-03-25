using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. ferreira", "857.032.950-41", "Branquinha", "arthur1@gmail.com");
        Cliente cliente2 = new Cliente(02, "Milena S. Silva", "123.654.877-21", "Mia", "milena1@gmail.com");
        Cliente cliente3 = new Cliente(03, "João G. Souza", "758.577.222-10", "Buck", "gariel1@gmail.com");
        Cliente cliente4 = new Cliente(04, "Rafael José da Senna", "265.369.987-11", "Sansão", "rafael1@gmail.com");
        Cliente cliente5 = new Cliente(05, "Raquel Silva Luke", "498.887.544-90", "Pretinha", "raquel1@gmail.com");

        // listas de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instacias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Pet Silva", "12.185.498/0001-80", "pet.silva@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Pet Souza", "12.125.438/0001-40", "pet.sauza@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "4 patas", "24.489.779/0001-50", "4patasa@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "med pet", "30.987.465/0001-10", "med.pet@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Hosítal do Pet", "45.978.798/0001-60", "hospitaldopet@gmail.com");

        // listas de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
