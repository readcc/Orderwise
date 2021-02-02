using OrderWise.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderWise.Services
{
    public class SQLiteHelper
    {
        readonly SQLiteAsyncConnection _database;

        public SQLiteHelper(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Customer>().Wait();
            _database.CreateTableAsync<CustomerCategory>().Wait();
            _database.CreateTableAsync<Order>().Wait();
            _database.CreateTableAsync<OrderItem>().Wait();
            _database.CreateTableAsync<Product>().Wait();
            
        }

        public Task<List<Customer>> GetCustomerAsync()
        {
            return _database.Table<Customer>().ToListAsync();
        }

        public Task<int> SaveCustomerAsync(Customer customer)
        {
            return _database.InsertAsync(customer);
        }

        public Task<List<Product>> GetProductAsync()
        {
            return _database.Table<Product>().ToListAsync();
        }

        public Task<int> SaveProductAsync(Product product)
        {
            return _database.InsertAsync(product);
        }

        public Task<List<CustomerCategory>> GetCategoriesAsync()
        {
            return _database.Table<CustomerCategory>().ToListAsync();
        }

        public Task<int> SaveCategoryAsync(CustomerCategory category)
        {
            return _database.InsertAsync(category);
        }

        public Task<List<Order>> GetOrdersAsync()
        {
            return _database.Table<Order>().ToListAsync();
        }

        public Task<int> SaveOrdersAsync(Order order)
        {
            return _database.InsertAsync(order);
        }
    }


}
