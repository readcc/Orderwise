using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWise.Models
{
    public class CustomerCategory
    {
        [PrimaryKey, AutoIncrement]
        public int CustomerCateforyId { get; set; }
        [MaxLength(32), NotNull]
        public String Description { get; set; }
    }
}
