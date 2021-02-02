using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWise.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        [MaxLength(8), Unique, NotNull]
        public String ProductCode { get; set; }
        [MaxLength(64), NotNull]
        public String ProductName { get; set; }
    }
}
