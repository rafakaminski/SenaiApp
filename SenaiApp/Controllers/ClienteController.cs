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
            return View();
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
            return View(model);
        }
    }
}