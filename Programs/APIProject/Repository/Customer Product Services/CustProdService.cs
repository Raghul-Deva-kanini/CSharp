using APIProject.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Repository.Customer_Product_Services
{
    public class CustProdService:ICustProductService
    {
        public StoreManagementContext _storeManagementContext;

        public CustProdService(StoreManagementContext storeManagementContext)
        {
            _storeManagementContext= storeManagementContext;
        }

        public async Task<List<CustomerProd>?> GetCustomerProds()
        {
            var cust = await _storeManagementContext.CustomerProds.ToListAsync();
            return cust;
        }

        public async Task<CustomerProd>? GetCustomerProd(int id)
        {
            var cust = await _storeManagementContext.CustomerProds.FindAsync(id);
            if (cust is null)
            {
                return null;
            }
            return cust;
        }

        public async Task<List<CustomerProd>?> PutCustomerProd(int id, CustomerProd cust)
        {
            var custs = await _storeManagementContext.CustomerProds.FindAsync(id);
            if (custs is null)
            {
                return null;
            }

            custs.CustomerId = cust.CustomerId;
            custs.ProductId = cust.ProductId;
            custs.ProductQuantity = cust.ProductQuantity;
            custs.TotalCost = cust.TotalCost;


            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.CustomerProds.ToListAsync();
        }

        public async Task<List<CustomerProd>> PostCustomerProd(CustomerProd cust)
        {
            _storeManagementContext.CustomerProds.Add(cust);
            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.CustomerProds.ToListAsync();
        }

        public async Task<List<CustomerProd>> DeleteCustomerProd(int id)
        {
            var cust = _storeManagementContext.CustomerProds.Find(id);
            _storeManagementContext.Remove(cust);
            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.CustomerProds.ToListAsync();
        }


    }
}
