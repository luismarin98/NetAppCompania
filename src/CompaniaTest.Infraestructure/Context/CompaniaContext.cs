using System;
using CompaniaTest.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CompaniaTest.Infraestructure.Context;

public class CompaniaContext : DbContext
{
        public CompaniaContext(DbContextOptions<CompaniaContext> options) : base(options)
        {
            
        }

        public DbSet<CompaniaModel> Models => Set<CompaniaModel>();
}
