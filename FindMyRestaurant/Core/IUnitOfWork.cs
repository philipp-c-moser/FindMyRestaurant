using System;
using FindMyRestaurant.Core.Repositories;

namespace FindMyRestaurant.Core
{
    public interface IUnitOfWork : IDisposable
    {

        #region Fields
        IRestaurantRepository RestaurantRepository { get; }
        #endregion


        #region Methods
        void SaveChanges();
        void SaveChangesAsync();
        new void Dispose();
        #endregion



    }
}
