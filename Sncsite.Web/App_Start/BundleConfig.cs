using System.Web;
using System.Web.Optimization;

namespace Sncsite.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.easing.1.3.js",
                      "~/Scripts/jquery.isotope.min.js",
                      "~/Scripts/jquery.nicescroll.min.js",
                      "~/Scripts/jquery.fancybox.pack.js",
                      "~/Scripts/jquery.scrollTo-1.4.3.1-min.js",
                      "~/Scripts/jquery.localscroll-1.2.7-min.js",
                      "~/Scripts/stellar.js",
                      "~/Scripts/jquery.appear.js",
                      "~/Scripts/validate.js"

                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/isotope.css",
                      "~/Content/style.css",
                      "~/Scripts/fancybox/jquery.fancybox.css",
                      "~/skin/default.css"));
        }
    }
}
