using System.ComponentModel.DataAnnotations.Schema;

namespace RentalBooksApi.Models.Base
{
    public class BaseEntity
    {
        [Column("id")] 
        public long Id { get; set; }
    }
}