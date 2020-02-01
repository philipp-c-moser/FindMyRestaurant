using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using FindMyRestaurant.Core.Repositories;
using FindMyRestaurant.Core.Domain;
using FindMyRestaurant.Infrastructure.Data;

namespace FindMyRestaurant.Infrastructure.Repositories
{
    public class VisitRepository : Repository<Visit>, IVisitRepository
    {
        public VisitRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<IList<Visit>> GetSortedDescByCreationAsync(int amount)
        {
            return await Set.OrderByDescending(v => v.Id).Take(amount).ToListAsync();
        }
    }
}