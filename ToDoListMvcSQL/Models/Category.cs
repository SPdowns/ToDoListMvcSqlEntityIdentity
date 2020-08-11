using System.Collections.Generic;

namespace ToDoListMvcSqlEntityIdentity.Models
{
  public class Category
  {
    public Category()
    {
      this.Items = new HashSet<CategoryItem>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<CategoryItem> Items { get; set; }
  }
}