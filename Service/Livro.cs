using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livraria.Service
{
    public class Livro
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Livro(int id, string name, double valor, int quantidade)
        {
            Id = id;
            Name = name;
            Valor = valor;
            Quantidade = quantidade;
        }
        public override string ToString()
        {
            return Name + ", R$" + Valor.ToString("F2") + ".";
        }
    }
}
