using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        [HttpPost]
        public async Task<IHttpActionResult> Post(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                Product product = await _context.Products.FindAsync(transaction.ProductId);
                if (product == null) 
                    return BadRequest("Invalid product Id");

                Customer customer = await _context.Customers.FindAsync(transaction.CustomerId);
                if (customer == null)
                    return BadRequest("Invalid customer Id");

                if (transaction.PurchaseQuantity > product.Quantity)
                    return BadRequest($"There are only {product.Quantity} left in stock");

                product.Quantity -= transaction.PurchaseQuantity;

                transaction.DateOfTransaction = DateTime.Now;
                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Transaction> transactions = await _context.Transactions.ToListAsync();
            return Ok(transactions);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById([FromUri] int id)
        {
            Transaction transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }

    }
}
