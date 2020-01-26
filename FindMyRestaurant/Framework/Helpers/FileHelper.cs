using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Framework.Helpers
{
    public static class FileHelper
    {

        #region PublicMethods
        public static string BuildImageUrl(string imageName, string fileType)
        {
            return "https://cnt.01.bb.delivery.philipp-moser.de/irfdoe2un/" + imageName + "." + fileType;
        }
        #endregion


        #region PrivateMethods
        #endregion




    }
}