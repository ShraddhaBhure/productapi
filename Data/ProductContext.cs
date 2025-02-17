using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productapi.Data;
using productapi.Models;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace productapi.Data
{
    public class ProductContext:DbContext
    {
       public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

    
    public DbSet<Product> Products {get; set; }
        
    }
}