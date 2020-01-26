using FindMyRestaurant.Core;
using FindMyRestaurant.Infrastructure.Data;

namespace FindMyRestaurant.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        #region Fields
        private readonly AppDbContext _context;
        #endregion

        #region Constructor
        public UnitOfWork()
        {
            _context = new AppDbContext();
        }
        #endregion


        #region Members
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
            _context.Dispose();
        }
        #endregion
    }
}