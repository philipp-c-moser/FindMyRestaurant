using FindMyRestaurant.Core;
using FindMyRestaurant.Infrastructure.Data;
using FindMyRestaurant.Core.Repositories;
using FindMyRestaurant.Infrastructure.Repositories;

namespace FindMyRestaurant.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        #region Fields
        private readonly AppDbContext _context;

        private IRestaurantRepository _restaurantRepository;
        private IRestaurantCategoryRepository _restaurantCategoryRepository;
        private IVisitRepository _visitRepository;
        #endregion

        #region Constructor
        public UnitOfWork()
        {
            _context = new AppDbContext();
        }
        #endregion


        #region Members
        public IRestaurantRepository RestaurantRepository
        {
            get { return _restaurantRepository ?? (_restaurantRepository = new RestaurantRepository(_context)); }
        }

        public IRestaurantCategoryRepository RestaurantCategoryRepository
        {
            get { return _restaurantCategoryRepository ?? (_restaurantCategoryRepository = new RestaurantCategoryRepository(_context)); }
        }

        public IVisitRepository VisitRepository
        {
            get { return _visitRepository ?? (_visitRepository = new VisitRepository(_context)); }
        }

        #endregion


        #region Methods
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async void SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Disposable Member
        public void Dispose()
        {
            _restaurantRepository = null;
            _restaurantCategoryRepository = null;
            _visitRepository = null;
            _context.Dispose();
        }
        #endregion
    }
}