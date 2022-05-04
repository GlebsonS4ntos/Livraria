using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Livraria.Service;

namespace WF_Livraria.Repository
{
    public class PedidosRepository
    {
        public static List<Pedido> todosPedidos = new List<Pedido>();

        public void AddPedidos(Pedido pedido)
        {
            todosPedidos.Add(pedido);
        }

        public List<Pedido> RetornarLista()
        {
            return todosPedidos;
        }
    }
}
