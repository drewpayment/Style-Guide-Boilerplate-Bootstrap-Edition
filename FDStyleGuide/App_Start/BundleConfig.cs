using System.Web;
using System.Web.Optimization;

namespace FDStyleGuide
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
                      "~/Scripts/respond.js"
                      //"~/Scripts/affix.js",
                      //"~/Scripts/alert.js",
                      //"~/Scripts/button.js",
                      //"~/Scripts/carousel.js",
                      //"~/Scripts/collapse.js",
                      //"~/Scripts/dropdown.js",
                      //"~/Scripts/modal.js",
                      //"~/Scripts/popover.js",
                      //"~/Scripts/scrollspy.js",
                      //"~/Scripts/sg-plugins.js",
                      //"~/Scripts/sg-scripts-ck.js",
                      //"~/Scripts/sg-scripts.js",
                      //"~/Scripts/tab.js",
                      //"~/Scripts/tooltip.js",
                      //"~/Scripts/transition.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styleguide.css",
                      "~/Content/theme.css"
                      ));
        }
    }
}
