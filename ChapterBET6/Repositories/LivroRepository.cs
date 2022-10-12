using ChapterBET6.Contexts;
using ChapterBET6.Models;

namespace ChapterBET6.Repositories
{
    public class LivroRepository
    {
        private readonly sqlcontext _context;

        public object?[]? Id { get; private set; }

        public LivroRepository(sqlcontext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

        public Livro BuscarPorId(int id)
        {
            return _context.Livros.Find(id);
        }

        public void Cadastrar(Livro nomeL)
        {
            _context.Livros.Add(nomeL);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro nomeL = _context.Livros.Find(id);

            _context.Livros.Remove(nomeL);

            _context.SaveChanges();
        }

        public void Alterar(int id, Livro nomeL)
        {
            Livro livroBuscado = _context.Livros.Find(id);
            if (livroBuscado != null)
            {
                livroBuscado.Titulo = nomeL.Titulo;
                livroBuscado.QuantidadePaginas = nomeL.QuantidadePaginas;
                livroBuscado.Disponivel = nomeL.Disponivel;
                _context.Livros.Update(livroBuscado);

                _context.SaveChanges();
               
            }

        }
    }
}
