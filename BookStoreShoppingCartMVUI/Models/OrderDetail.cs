using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCartMVUI.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    { // orderdetails has a relationship with OrderID, BookID 
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        //this is the relationship BookID and OrderID are FK
        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}