using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWise.Models
{
    class OrderItem
    {
        [PrimaryKey, AutoIncrement]
        public int OrderItemId { get; set; }
        [NotNull] 
        public int OrderId { get; set; }
        [NotNull] 
        public int ProductId { get; set; }
        [NotNull] 
        public int Quantity { get; set; }
        [NotNull]
        public Double UnitPrice { get; set; }
    }
}
