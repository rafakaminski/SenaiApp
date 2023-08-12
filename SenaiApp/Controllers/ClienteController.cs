using Microsoft.AspNetCore.Mvc;
using SenaiApp.Domain.Entidade;
using SenaiApp.Service.Interfaces;

namespace SenaiApp.Controllers
{
    public class ClienteController : Controller
    {

        private IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            var clientes = _clienteService.BuscarTodas();
            ViewBag.Clientes = clientes;
            return View();
        }

        public IActionResult Editar(long id)
        {
            var cliente = _clienteService.BuscarTodas().First(x => x.Id == id);
            return View("Form", cliente);
        }

        public IActionResult Form()
        {
            var model = new Cliente();
            return View(model);
        }

        [HttpPost]
        public IActionResult Form(Cliente model)
        {
            var cliente = _clienteService.Salvar(model);
            return RedirectToAction("Index");
        }

        public IActionResult Remover(long id)
        {
            _clienteService.Remover(id);
            return RedirectToAction("Index");
        }

    }
}