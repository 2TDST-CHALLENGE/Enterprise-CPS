using WebApplicationForChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationForChallenge.Persistencia
{
    //Classe que gerencia as entidades
    public class FabricaContext : DbContext
    {
        //Propriedades que representam as entidades no banco de dados
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoEstabelecimento> ProdutoEstabelecimentos { get; set; }

        //Construtor que rebece algumas opções, como a string de conexão
        public FabricaContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a chave composta da tabela associativa
            modelBuilder.Entity<ProdutoEstabelecimento>().HasKey(f => new { f.ProdutoId, f.Codigo });

            //Configurar a relação da tabela associativa com o funcionario
            modelBuilder.Entity<ProdutoEstabelecimento>()
                .HasOne(f => f.Estabelecimento)
                .WithMany(f => f.ProdutoEstabelecimentos)
                .HasForeignKey(f => f.Codigo);

            //Configurar a relação da tabela associativa com o benefício
            modelBuilder.Entity<ProdutoEstabelecimento>()
                .HasOne(f => f.Produto)
                .WithMany(f => f.ProdutoEstabelecimentos)
                .HasForeignKey(f => f.ProdutoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
