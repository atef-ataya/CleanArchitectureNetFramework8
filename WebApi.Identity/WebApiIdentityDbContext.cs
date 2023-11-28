using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Identity.Models;

namespace WebApi.Identity
{
    public class WebApiIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public WebApiIdentityDbContext(DbContextOptions<WebApiIdentityDbContext> options) : base(options) { }
    }
}
