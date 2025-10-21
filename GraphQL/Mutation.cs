using GraphQLCRUDDemo.Data;
using GraphQLCRUDDemo.Models;

namespace GraphQLCRUDDemo.GraphQL
{
    public class Mutation
    {
        // CREATE
        public async Task<Customer> AddCustomer(string name, string email, AppDbContext context)
        {
            var customer = new Customer { Name = name, Email = email };
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        // UPDATE
        public async Task<Customer?> UpdateCustomer(int id, string? name, string? email, AppDbContext context)
        {
            var customer = await context.Customers.FindAsync(id);
            if (customer == null) return null;

            if (!string.IsNullOrEmpty(name)) customer.Name = name;
            if (!string.IsNullOrEmpty(email)) customer.Email = email;

            await context.SaveChangesAsync();
            return customer;
        }

        // DELETE
        public async Task<bool> DeleteCustomer(int id, AppDbContext context)
        {
            var customer = await context.Customers.FindAsync(id);
            if (customer == null) return false;

            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
