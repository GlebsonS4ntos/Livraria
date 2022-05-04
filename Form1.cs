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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> pagamentos = new(){"Dinheiro", "Boleto", "Cartão"};
            pagamentos.ForEach(p => cbxPagamento.Items.Add(p));

            List<int> parcelas = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            parcelas.ForEach(p => cbxParcelas.Items.Add(p));

            List<Livro> Livros = LivroRepository.InicializarLivro();
            List<Cliente> Clientes = ClienteRepository.InicializarClients();

            Livros.ForEach(l => cbxLivros.Items.Add(l.ToString()));
            Clientes.ForEach(p => cbxClientes.Items.Add(p.ToString()));

            lblParcelas.Visible = false;
            cbxParcelas.Visible = false;
        }

        private void cbxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxPagamento.SelectedIndex == 2)
            {
                lblParcelas.Visible = true;
                cbxParcelas.Visible = true;
            }
            else
            {
                lblParcelas.Visible = false;
                cbxParcelas.Visible = false;
            }
        }

        private void btnListaPedidos_Click(object sender, EventArgs e)
        {
            ExibirPedidos ex = new();
            ex.ShowDialog();
        }

        private void cbxLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            LivroRepository l = new();
            Livro livro = l.BuscarLivro(cbxLivros.SelectedIndex+1);
            for(int j = 1; j <= livro.Quantidade; j++)
            {
                cbxQuantidade.Items.Add(j.ToString());
            }
        }

        private void bntCadastrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteRepository c = new();
                Cliente cliente = c.BuscarCliente(cbxClientes.SelectedIndex + 1);
                LivroRepository l = new();
                Livro livro = l.BuscarLivro(cbxLivros.SelectedIndex + 1);
                string formaPagamento = cbxPagamento.Text; 
                Pedido p = new(cliente.Cpf, livro, int.Parse(cbxQuantidade.Text),formaPagamento);
                PedidosRepository pr = new();
                pr.AddPedidos(p);
                MessageBox.Show("Compra Feita com sucesso !");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
