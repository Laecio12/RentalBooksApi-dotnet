using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RentalBooksApi.Models.Base;

namespace RentalBooksApi.Models
{
    [Table("categories")]
    public class Category : BaseEntity
    {
        public Category()
        {
            Books = new Collection<Book>();
        }

        [Column("name")] 
        [Required]
        [StringLength(80)]
        public string CategoryName { get; set; }

        private ICollection<Book> Books { get; set; }
    }
}