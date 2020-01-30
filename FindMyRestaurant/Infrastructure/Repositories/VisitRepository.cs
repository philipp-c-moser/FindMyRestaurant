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
    }
}