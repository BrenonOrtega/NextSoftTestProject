using Microsoft.EntityFrameworkCore;
using NextSoftTest.Models;

namespace NextSoftTest.Data
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> opt) : base(opt)
        {
            
        }

        public DbSet<cadastro> Cadastros { get; set; }
    }
}