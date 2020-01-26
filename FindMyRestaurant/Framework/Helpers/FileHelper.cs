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
            return GetCdnServerAddress() + imageName + "." + fileType;
        }
        #endregion


        #region PrivateMethods
        private static string GetCdnServerAddress()
        {
            return System.Configuration.ConfigurationManager.AppSettings["CdnServerAddress"];
        }
        #endregion




    }
}