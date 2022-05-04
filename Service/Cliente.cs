using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livraria.Service
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public Int64 Cpf { get;private set; }
        public string Name { get; set; }

        public Cliente(int idCliente, long cpf, string name)
        {
            IdCliente = idCliente;
            Cpf = cpf;
            Name = name;
        }

        public override string ToString()
        {
            return "Cpf: " + Cpf + " - " + Name;
        }
    }
}
