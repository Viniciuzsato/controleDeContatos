using ControleContato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ControleContato.Data
{
    public class BancoContext :DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
         public DbSet<ContatoModel> Contatos{ get; set; }
    }
}
