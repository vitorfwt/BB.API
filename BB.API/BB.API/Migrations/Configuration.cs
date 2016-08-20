namespace BB.API.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BB.API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BB.API.Models.ApplicationDbContext context)
        {
            context.Produtos.AddOrUpdate(x => x.Id,
                new Produto() { Id = 1, Nome = "Saia", Preco = 3.50 }
                );
        }
    }
}
