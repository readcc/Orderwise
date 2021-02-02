using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWise.Models
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int OrderId { get; set; }
        [NotNull]
        public int CustomerId { get; set; }
        [NotNull]
        public DateTime OrderDate { get; set; }
        [MaxLength(32), NotNull]
        public String CustomerReference { get; set; }
    }
}
