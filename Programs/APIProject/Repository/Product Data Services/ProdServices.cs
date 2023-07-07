using APIProject.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Repository.Product_Data_Services
{
    public class ProdServices:IProdServices
    {
        public StoreManagementContext _storeManagementContext;

        public ProdServices(StoreManagementContext storeManagementContext)
        {
            _storeManagementContext = storeManagementContext;
        }

        public async Task<List<ProductDatum>?> GetProductData()
        {
            var prod = await _storeManagementContext.ProductData.ToListAsync();
            return prod;
        }

        public async Task<ProductDatum>? GetProductDatum(string id)
        {
            var prod = await _storeManagementContext.ProductData.FindAsync(id);
            if (prod is null)
            {
                return null;
            }
            return prod;
        }

        public async Task<List<ProductDatum>?> PutProduct(string id, ProductDatum productDatum)
        {
            var prod = await _storeManagementContext.ProductData.FindAsync(id);
            if (prod is null)
            {
                return null;
            }

            prod.ProductName = productDatum.ProductName;
            prod.QuantityAvailable = productDatum.QuantityAvailable;
            prod.Cost = productDatum.Cost;

            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.ProductData.ToListAsync();
        }

        public async Task<List<ProductDatum>> PostProductDatum(ProductDatum productDatum)
        {
            _storeManagementContext.ProductData.Add(productDatum);
            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.ProductData.ToListAsync();
        }

        public async Task<List<ProductDatum>> DeleteProductdatum(string id)
        {
            var prod = _storeManagementContext.ProductData.Find(id);
            _storeManagementContext.Remove(prod);
            await _storeManagementContext.SaveChangesAsync();
            return await _storeManagementContext.ProductData.ToListAsync();
        }
    }
}
