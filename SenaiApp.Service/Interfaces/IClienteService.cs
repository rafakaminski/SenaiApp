using SenaiApp.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Service.Interfaces
{
    public interface IClienteService
    {
        Cliente Salvar(Cliente cliente);

        List<Cliente> BuscarTodas();

        bool Remover(long id);


    }
}
