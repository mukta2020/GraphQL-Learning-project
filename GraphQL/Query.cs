using GraphQLCRUDDemo.Data;
using GraphQLCRUDDemo.Models;

namespace GraphQLCRUDDemo.GraphQL
{
    public class Query
    {
        public IQueryable<Customer> GetCustomers(AppDbContext context) => context.Customers;
        public Customer? GetCustomerById(int id, AppDbContext context) => context.Customers.Find(id);
    }
}
