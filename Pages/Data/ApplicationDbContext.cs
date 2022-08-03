
using Microsoft.EntityFrameworkCore;

namespace PATENT_web.Pages.Data;


public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Categorias> Categories { get; set; }
}
