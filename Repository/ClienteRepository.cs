using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Livraria.Service;

namespace WF_Livraria.Repository
{
    public class ClienteRepository
    {
        public static List<Cliente> InicializarClients()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente(1, 12312312312, "Glebson Santos"));
            clientes.Add(new Cliente(2, 14412354343, "Maria Joaquina"));
            clientes.Add(new Cliente(3, 98798798754, "João Silva"));
            clientes.Add(new Cliente(4, 87434523453, "Alex Tavares"));
            clientes.Add(new Cliente(5, 02423023410, "Guilherme Oliveira"));
            clientes.Add(new Cliente(6, 76239783202, "Raquel Lima"));

            return clientes;
        }

        public Cliente? BuscarCliente(int id)
        {
            List<Cliente> clientes = InicializarClients();
            foreach (Cliente c in clientes)
            {
                if (c.IdCliente == id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
