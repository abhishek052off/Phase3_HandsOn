using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceModule.Models;

namespace EcommerceModule.DAL
{
    public class EcommDBContext : DbContext
    {
        public EcommDBContext(DbContextOptions<EcommDBContext> options) : base(options)
        {

        }

        public DbSet<ProductItem> Products { get; set; }
    }
}
