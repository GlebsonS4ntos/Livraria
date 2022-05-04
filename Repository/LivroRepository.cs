using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Livraria.Service;

namespace WF_Livraria.Repository
{
    public class LivroRepository
    {
        public static List<Livro> InicializarLivro()
        {
            List<Livro> livros = new List<Livro>();
            livros.Add(new Livro(1, "As Cronicas de Narnia", 50.00, 20));
            livros.Add(new Livro(2, "Harry Potter", 70.00, 1000));
            livros.Add(new Livro(3, "Game of thrones", 90.00, 200));
            livros.Add(new Livro(4, "Clean Code", 40.00, 700));
            livros.Add(new Livro(5, "Dom Quixote", 40.00, 700));

            return livros;
        }

        public Livro? BuscarLivro(int id)
        {
            List<Livro> livros = InicializarLivro();
            foreach (Livro l in livros)
            {
                if (l.Id == id)
                {
                    return l;
                }
            }
            return null;
        }
    }
}
