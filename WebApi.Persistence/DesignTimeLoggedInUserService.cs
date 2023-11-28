using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Application.Contracts;

namespace WebApi.Persistence
{
    public class DesignTimeLoggedInUserService : ILoggedInUserService
    {
        public string UserId => "design-time-user"; // Or use null or a fixed value as needed
                                                    // Implement other properties/methods with default or mock behavior
    }

}
