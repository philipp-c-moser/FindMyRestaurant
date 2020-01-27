
using System.Text;
using System.Web;

namespace FindMyRestaurant.Framework.Helpers
{
    public static class CustomHtmlHelper
    {


        #region Public Methods
        public static IHtmlString PageTitleRow(string pageTitle)
        {
            var html = new StringBuilder();

            html.Append("<!-- start page title -->");
            html.Append("<div class=\"row\">");
            html.Append("<div class=\"col-12\">");

            html.Append("<div class=\"page-title-box\">");

            html.Append("<h4 class=\"page-title\">");
            html.Append(pageTitle);
            html.Append("</h4>");

            html.Append("</div>");

            html.Append("</div>");
            html.Append("</div>");
            html.Append("<!-- end page title -->");

            return new HtmlString(html.ToString());
        }


        #endregion



    }
}