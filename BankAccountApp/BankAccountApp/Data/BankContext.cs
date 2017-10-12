using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccountApp.Data
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
            
        }
    }

   
}
