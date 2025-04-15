using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext //Herança do IdentityDbContext para incluir autenticação
    {
        //Construtot que recebe as opções de configuração do DbContext
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }
        //Sobrecarrega o método OnModelCreating para configurar o modelo a partir da IdentityDbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chama o método OnModelCreating da classe base para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);

            //Configurar a criação de tabela de adicionais 
        }
    }
}

