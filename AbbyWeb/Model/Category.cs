using System.ComponentModel.DataAnnotations;

//    for this we have to install two packages.
//    Microsoft.EntityFrameworkCore
//    Microsoft.EntityFrameworkCore.SqlServer

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
