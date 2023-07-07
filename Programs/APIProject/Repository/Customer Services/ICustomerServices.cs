using APIProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Repository.Customer_Services
{
    public interface ICustomerServices
    {
        Task<List<Customer>?> GetCustomers();
        Task<Customer>? GetCustomer(int id);
        Task<List<Customer>?> PutCustomer(int id, Customer cust);
        Task<List<Customer>> PostCustomer(Customer cust);
        Task<List<Customer>> DeleteCustomer(int id);
    }
}
