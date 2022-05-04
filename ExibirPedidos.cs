using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Livraria.Repository;
using WF_Livraria.Service;

namespace WF_Livraria
{
    public partial class ExibirPedidos : Form
    {
        public ExibirPedidos()
        {
            InitializeComponent();
        }

        private void ExibirPedidos_Load(object sender, EventArgs e)
        {
            PedidosRepository p = new PedidosRepository();
            List<Pedido> lista = p.RetornarLista();
            lista.ForEach(x => lbxPedidos.Items.Add(x));

            double valorTotal = 0;
            lista.ForEach(x => valorTotal += x.Valor);
            lblTotal.Text = valorTotal.ToString();
        }
    }
}
