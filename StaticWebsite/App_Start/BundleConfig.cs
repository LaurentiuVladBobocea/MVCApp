using System.Web;
using System.Web.Optimization;

namespace StaticWebsite
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

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/Scripts/js/vendor/bootstrap.min.js",
                       "~/Scripts/js/vendor/jquery-1.9.1.min.js",
                 "~/Scripts/js/vendor/modernizr-2.6.2-respond-1.1.0.min.js",
                 "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/js/jquery.ba-cond.min.js",
                "~/Scripts/js/jquery.slitslider.js",
                "~/Scripts/js/main.js",
                "~/Scripts/js/twitter-bootstrap-hover-dropdown.min.js"
                ));


            //bundles.Add(new ScriptBundle("~/Scripts/js/vendor").Include(
            //          "~/Scripts/js/vendor/bootstrap.min.js",
            //           "~/Scripts/js/vendor/jquery-1.9.1.min.js",
            //            "~/Scripts/js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"));
            //bundles.Add(new ScriptBundle("~/Scripts/js/vendor").Include(
            //    "~/Scripts/js/bootstrap.min.js",
            //    "~/Scripts/js/jquery.ba-cond.min.js",
            //    "~/Scripts/js/jquery.slitslider.js",
            //    "~/Scripts/js/main.js",
            //    "~/Scripts/js/twitter-bootstrap-hover-dropdown.min.js"
            //    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap-responsive.min.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/main.css",
                      "~/Content/css/sl-slide.css"));
        }
    }
}
