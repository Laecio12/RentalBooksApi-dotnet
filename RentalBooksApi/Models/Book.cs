using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
        public decimal Price { get; set; }
        
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
        
        public int CategoryId { get; set; }
    
        [JsonIgnore]
        public Category Category { get; set; }
    
    }
}