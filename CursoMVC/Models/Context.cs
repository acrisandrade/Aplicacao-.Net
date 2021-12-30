using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        //Passo para o Entity que tera uma tabela tal.
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> produtos { get; set; }



        //Este metodo e o responsavel por configurar o Entity Framework,
        //e nele que dizemos qual banco de dados sera utilizado.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\mssqllocaldb; Database=CursoMVC; Integrated Security = True");
        }
    }
}
