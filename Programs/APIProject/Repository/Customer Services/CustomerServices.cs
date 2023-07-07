using APIProject.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Repository.Customer_Services
{
    public class CustomerServices:ICustomerServices
    {
        public StoreManagementContext _storeManagementContext;

        public CustomerServices(StoreManagementContext storeManagementContext)
        {
            _storeManagementContext = storeManagementContext;
        }

        public async Task<List<Customer>?> GetCustomers()
        {
            var cust = await _storeManagementContext.Customers.ToListAsync();
            return cust;
        }

        public async Task<Customer>? GetCustomer(int id)
        {
            var cust = await _storeManagementContext.Customers.FindAsync(id);
            if (cust is null)
            {
                return null;
            }
            return cust;
        }

        public async Task<List<Customer>?> PutCustomer(int id, Customer cust)
        {
            var custs = await _storeManagementContext.Customers.FindAsync(id);
            if (custs is null)
            {
                return null;
            }

            custs.CustomerName = cust.CustomerName;
            custs.Email = cust.Email;
            custs.Phone = cust.Phone;

            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.Customers.ToListAsync();
        }

        public async Task<List<Customer>> PostCustomer(Customer cust)
        {
            _storeManagementContext.Customers.Add(cust);
            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.Customers.ToListAsync();
        }

        public async Task<List<Customer>> DeleteCustomer(int id)
        {
            var cust = _storeManagementContext.Customers.Find(id);
            _storeManagementContext.Remove(cust);
            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.Customers.ToListAsync();
        }
    }
}