using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RentalBooksApi.Models.Base;

namespace RentalBooksApi.Models
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("author")]
        [Required]
        [StringLength(100)]
        public string Author { get; set; }
        
        [Column("title")]
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        
        [Column("price", TypeName = "decimal(10,2)")]
        [Required]
        [StringLength(100)]
        public decimal Price { get; set; }
        
        [Column("launch_date")]
        
        [Required]
        [StringLength(100)]
        public DateTime LaunchDate { get; set; }
    }
}