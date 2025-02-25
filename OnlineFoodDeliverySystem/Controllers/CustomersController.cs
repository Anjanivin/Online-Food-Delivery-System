﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineFoodDeliverySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly FoodDbContext _context;

        public CustomersController(FoodDbContext context)
        {
            _context = context;
        }
        //Register
        [HttpPost]
        public void Register([FromBody] Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        //Login
        [HttpGet]
        public Customer GetCustomer(int id)
        {
            return _context.Customers.SingleOrDefault(p => p.CustomerID == id);
        }

    }
}
