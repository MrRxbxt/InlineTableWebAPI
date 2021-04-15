using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlineTableWebAPI.Models
{
    public class BankDbContext: DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options):base(options)
        {

        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
