using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Application.Contracts.Caching;

namespace WebApi.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>, ICacheableMediatrQuery
    {
        public bool BypassCache { get; set; }
        public string CacheKey => $"CategoryList";
        public TimeSpan? SlidingExpiration { get; set; }
    }
}
