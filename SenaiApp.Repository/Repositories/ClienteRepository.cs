using Microsoft.EntityFrameworkCore;
using SenaiApp.Domain.Entidade;
using SenaiApp.Repository.Context;
using SenaiApp.Repository.Interfaces;
using SenaiApp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Repository.Repositorios
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {

        public ClienteRepository(SenaiAppContext context) : base(context) { }

        public List<Cliente> PegarTodas()
        {
            return GetAll().ToList();
        }

        public Cliente SalvarCliente(Cliente cliente)
        {
            return Salvar(cliente);
        }

        public bool RemoverCliente(long id)
        {
            try
            {
                Remover(id);
                return true;
            }
            catch
            { 
                return false; 
            }
        }
    }
}