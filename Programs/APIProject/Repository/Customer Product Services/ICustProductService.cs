using APIProject.Models;

namespace APIProject.Repository.Customer_Product_Services
{
    public interface ICustProductService
    {
        Task<List<CustomerProd>?> GetCustomerProds();

        Task<CustomerProd>? GetCustomerProd(int id);

        Task<List<CustomerProd>?> PutCustomerProd(int id, CustomerProd cust);

        Task<List<CustomerProd>> PostCustomerProd(CustomerProd cust);

        Task<List<CustomerProd>> DeleteCustomerProd(int id);

    }
}
