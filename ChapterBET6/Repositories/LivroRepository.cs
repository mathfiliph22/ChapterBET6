using ChapterBET6.Contexts;
using ChapterBET6.Models;

namespace ChapterBET6.Repositories
{
    public class LivroRepository
    {
        private readonly sqlcontext _context;
        public LivroRepository(sqlcontext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }



        

    }
}
