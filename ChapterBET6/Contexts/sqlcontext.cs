using ChapterBET6.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterBET6.Contexts
{
    public class sqlcontext: DbContext
    {
        public sqlcontext()
        {
        }
        public sqlcontext(DbContextOptions<sqlcontext>options): base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                //optionsBuilder.UseSqlServer("DataSource = DESKTOP-EVSV1E0\\SQLEXPRESS; initial catalog = Chapter;User Id = sa; Password = 190217");
                optionsBuilder.UseSqlServer("Server = DESKTOP-EVSV1E0\\SQLEXPRESS; Database = Chapter;User Id = sa; Password = 190217;");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

    }
}
