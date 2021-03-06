﻿using System.Web;
using System.Web.Optimization;

namespace FindMyRestaurant
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            #region ThemeBundles            
            bundles.Add(new StyleBundle("~/Content/Theme/Basic").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/Theme/icons.css",
                    "~/Content/Theme/app.css",
                    "~/Content/Theme/custom.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/Theme/Basic").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/Theme/vendor.min.js",
                    "~/Scripts/Theme/app.min.js"
                ));
            #endregion


            #region Plugins            
            bundles.Add(new StyleBundle("~/Content/Plugins/RangeSlider").Include("~/Plugins/ion-rangeslider/ion.rangeSlider.css"));
            bundles.Add(new ScriptBundle("~/bundles/Plugins/RangeSlider").Include("~/Plugins/ion-rangeslider/ion.rangeSlider.min.js"));
            #endregion




        }
    }
}
