using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyRestaurant.Core
{
    public interface IUnitOfWork : IDisposable
    {

        #region Fields
        #endregion


        #region Methods
        void SaveChanges();
        void SaveChangesAsync();
        new void Dispose();
        #endregion



    }
}
