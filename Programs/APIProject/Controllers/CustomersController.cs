using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIProject.Models;
using APIProject.Repository.Customer_Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    //[Authorize]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomersController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        // GET: api/Customers
        /*[HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>?>> GetCustomers()
        {
            return Ok(await _customerServices.GetCustomers());
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]

        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var cust = await _customerServices.GetCustomer(id);

            if (cust == null)
            {
                return NotFound("Dept id not matching");
            }

            return Ok(cust);
        }
       

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]

        public async Task<List<Customer>?> PutCustomer(int id, Customer cust)
        {
            return await _customerServices.PutCustomer(id, cust);
        }*/
        

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]

        public async Task<ActionResult<Customer>> PostCustomer(Customer cust)
        {
            var custs = await _customerServices.PostCustomer(cust);
            return Ok(custs);
        }
       

        // DELETE: api/Customers/5
        /*[HttpDelete("{id}")]
        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)
        {
            var cust = await _customerServices.DeleteCustomer(id);

            if (cust == null)
            {
                return NotFound("Dept id not matching");
            }
            return Ok(cust);
        }*/
    }
}
