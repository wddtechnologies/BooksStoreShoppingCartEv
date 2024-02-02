﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreShoppingCartMVUI.Models
{
    [Table("Order")]
    public class Order
    {//order has a relationship with UserId and OrderStatus 
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
    }
}