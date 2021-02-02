using SQLite;

namespace OrderWise.Services
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int CustomerId { get; set; }
        [MaxLength(8), Unique, NotNull]
        public string CustomerCode { get; set; }
        [MaxLength(128), NotNull]
        public string CustomerName { get; set; }
        [MaxLength(10), NotNull]
        public string Telephone { get; set; }
        [MaxLength(10), NotNull]
        public string Cellphone { get; set; }
        [MaxLength(128), NotNull]
        public string Address1 { get; set; }
        [MaxLength(128), NotNull]
        public string Address2 { get; set; }
        [MaxLength(128), NotNull]
        public string Address3 { get; set; }
        [MaxLength(128), NotNull]
        public string Address4 { get; set; }
        [MaxLength(8), NotNull]
        public string PostalCode { get; set; }
        [ NotNull]
        public int CustomerCategoryId { get; set; }
    }
}
