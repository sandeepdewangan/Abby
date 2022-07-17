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
        [Display(Name="Display Order")]
        [Range(1,100, ErrorMessage ="Display order must be in a range of 0-100")]
        public int DisplayOrder { get; set; }
    }
}
