using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RentalBooksApi.Models.Base;

namespace RentalBooksApi.Models
{
    public class Category : BaseEntity
    {
        [Column("name")] 
        [Required]
        [StringLength(80)]
        public string CategoryName { get; set; }
    }
}