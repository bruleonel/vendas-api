using Microsoft.EntityFrameworkCore;
using vendas.Models;

namespace vendas.Context;

public class UsuarioContext : DbContext
{
    public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
    {
    }

    public DbSet<Usuario> UsuarioList { get; set; } = null!;
}