using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProject.Models;
using APIProject.Repository.Customer_Services;
using APIProject.Repository.Customer_Product_Services;
using Microsoft.AspNetCore.Authorization;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles="Admin|User")]
    public class CustomerProdsController : ControllerBase
    {
        private readonly ICustProductService _custProductService;

        public CustomerProdsController(ICustProductService custProductService)
        {
            _custProductService = custProductService;
        }

        // GET: api/CustomerProds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerProd>?>> GetCustomerProds()
        {
            return Ok(await _custProductService.GetCustomerProds());
        }



        // GET: api/CustomerProds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerProd>> GetCustomerProd(int id)
        {
            var cust = await _custProductService.GetCustomerProd(id);

            if (cust == null)
            {
                return NotFound("Cust id not matching");
            }

            return Ok(cust);
        }


        // PUT: api/CustomerProds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<CustomerProd>?> PutCustomerProd(int id, CustomerProd customerProd)
        {
            return await _custProductService.PutCustomerProd(id, customerProd);
        }


        // POST: api/CustomerProds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerProd>> PostCustomerProd(CustomerProd customerProd)
        {
            var custs = await _custProductService.PostCustomerProd(customerProd);
            return Ok(custs);
        }



        // DELETE: api/CustomerProds/5
        [HttpDelete("{id}")]

        public async Task<ActionResult<List<CustomerProd>>> DeleteCustomerProd(int id)
        {
            var cust = await _custProductService.DeleteCustomerProd(id);
            if (cust == null)
            {
                 return NotFound("Dept id not matching");
            }
            return Ok(cust);
        }
    }
}
