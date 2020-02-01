using System.Threading.Tasks;
using System.Collections.Generic;

using FindMyRestaurant.Core.Domain;

namespace FindMyRestaurant.Core.Repositories
{
    public interface IVisitRepository : IRepository<Visit>
    {
        Task<IList<Visit>> GetSortedDescByCreationAsync(int amount);
    }
}
