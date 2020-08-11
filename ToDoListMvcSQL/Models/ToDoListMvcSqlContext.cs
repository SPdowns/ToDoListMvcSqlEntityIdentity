using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoListMvcSqlEntityIdentity.Models
{
  public class ToDoListMvcSqlEntityIdentityContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CategoryItem> CategoryItem { get; set;}

    public ToDoListMvcSqlEntityIdentityContext(DbContextOptions options) : base(options) { }
  }
}