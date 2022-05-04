using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livraria.Service
{
    public class Pedido
    {
        public Int64 CpfCliente { get; set; }
        public Livro Livro { get; set; }
        public int QuantidaProduto { get; set; }
        public double Valor { get; set; }
        public string Pagamento { get; set; }
        //public int QuantidadeVezes { get; set; }

        public Pedido(long cpfCliente, Livro livro, int quantidaProduto, string pagamento)
        {
            CpfCliente = cpfCliente;
            Livro = livro;
            QuantidaProduto = quantidaProduto;
            Valor = (QuantidaProduto * livro.Valor);
            Pagamento = pagamento;
        }

        public override string ToString()
        {
            return "O cliente com CPF: " + CpfCliente.ToString() + ", comprou " + QuantidaProduto +
                " livros cujo nome é " + Livro.Name + ", e o valor é de " + Valor + ", no " + Pagamento;
        }
    }
}
