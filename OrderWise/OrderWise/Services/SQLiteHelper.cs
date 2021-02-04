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
            string path = dbPath;
        }

        public Task<List<Customer>> GetCustomerAsync()
        {
            return _database.Table<Customer>().ToListAsync();
        }

        public Task<int> SaveCustomerAsync(Customer customer)
        {
            return _database.InsertAsync(customer);
        }

        public Task<int> UpdateCustomerAsync(Customer customer)
        {
            return _database.UpdateAsync(customer);
        }

        public Task<int> DeleteCustomerAsync(Customer customer)
        {
            return _database.DeleteAsync(customer);
        }


        public Task<List<Product>> GetProductAsync()
        {
            return _database.Table<Product>().ToListAsync();
        }

        public Task<int> SaveProductAsync(Product product)
        {
            return _database.InsertAsync(product);
        }

        public Task<int> UpdateProductAsync(Product product)
        {
            return _database.UpdateAsync(product);
        }

        public Task<int> DeleteProductAsync(Product product)
        {
            return _database.DeleteAsync(product);
        }

        public Task<List<CustomerCategory>> GetCategoriesAsync()
        {
            return _database.Table<CustomerCategory>().ToListAsync();
        }

        public Task<int> SaveCategoryAsync(CustomerCategory category)
        {
            return _database.InsertAsync(category);
        }

        public Task<int> UpdateCategoryAsync(CustomerCategory category)
        {
            return _database.UpdateAsync(category);
        }

        public Task<int> DeleteCategoryAsync(CustomerCategory category)
        {
            return _database.DeleteAsync(category);
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
