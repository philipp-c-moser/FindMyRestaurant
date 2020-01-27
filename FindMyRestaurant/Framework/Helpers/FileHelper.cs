using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Framework.Helpers
{
    public static class FileHelper
    {
        private static readonly string _cdnServerAddress;

        static FileHelper()
        {
            _cdnServerAddress = System.Configuration.ConfigurationManager.AppSettings["CdnServerAddress"];
        }

        #region PublicMethods
        public static string BuildImageUrl(string imageName, string fileType)
        {
            return _cdnServerAddress + imageName + "." + fileType;
        }
        #endregion

    }
}