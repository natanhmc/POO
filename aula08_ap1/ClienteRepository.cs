using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1
{
    public class ClienteRepository
    {
        private List<Cliente> _clientes;

        public ClienteRepository()
        {
            _clientes = new List<Cliente>();
        }
        public void Add(Cliente cliente)
        {
            _clientes.Add(cliente);
        }
        public void Remove(int id)
        {
            Cliente cliente = _clientes.Find(c => c.Id == id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
            }
        }
        public string getAll()
        {
            string nomes = "";
            foreach (var cliente in _clientes)
            {
                nomes += $"ID: {cliente.Id} | Nome: {cliente.Nome}\n";
            }
            return nomes;
        }
        public Cliente GetClienteById(int id)
        {
            foreach (var cliente in _clientes)
            {
                if (cliente.Id == id)
                {
                    return cliente;
                }
            }
            return null;
        }
    }
}