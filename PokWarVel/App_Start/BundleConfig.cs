using System.Web;
using System.Web.Optimization;

namespace PokWarVel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/js/audio.min.js",
                      "~/Scripts/js/coundown-timer.js",
                      "~/Scripts/js/gmaps.js",
                      "~/Scripts/js/holder.js",
                      "~/Scripts/js/html5shiv.js",
                      "~/Scripts/js/jquery.countTo.js",
                      "~/Scripts/js/jquery.fitvids.js",
                      "~/Scripts/js/jquery.isotope.min.js",
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/css/animate.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/lightbox.css",
                      "~/Content/css/main.css",
                      "~/Content/css/prettyPhoto.css",
                      "~/Content/css/responsive.css"
                      ));
        }
    }
}
