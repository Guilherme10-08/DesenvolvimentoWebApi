using FruttiCultura.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FruttiCultura.DataContext
{
    public class FrutaDataContext : DbContext
    {
        public DbSet<Fruta> fruta { get; set; }
        public FrutaDataContext(DbContextOptions<FrutaDataContext> options):base(options)
        {}

    }
}
