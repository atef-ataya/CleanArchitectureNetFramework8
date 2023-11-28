using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Application.Contracts;

namespace WebApi.Persistence
{
    public class WebApiDbContextFactory : IDesignTimeDbContextFactory<WebApiDbContext>
    {
        public WebApiDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebApiDbContext>();
            optionsBuilder.UseSqlServer("WebApiConnectionString");

            var loggedInUserService = new DesignTimeLoggedInUserService(); // Design-time implementation

            return new WebApiDbContext(optionsBuilder.Options, loggedInUserService);
        }
    }


}
