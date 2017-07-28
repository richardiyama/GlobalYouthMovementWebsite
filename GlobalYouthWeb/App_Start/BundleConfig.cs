using System.Web;
using System.Web.Optimization;

namespace GlobalYouthWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                             "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery-2.1.4.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery2").Include(
                       "~/Scripts/jquery-1.10.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/Smoothscroll").Include(
                         "~/Scripts/move-top.js",
                         "~/Scripts/easing.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryflexslider").Include(
                        "~/Scripts/jquery.flexslider.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/chartist.min.js",
                       "~/Scripts/bootstrap-notify.js",
                        "~/Scripts/jquery.nicescroll.js",
                      "~/Scripts/bootstrap-checkbox-radio-switch.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.min.css",
                      "~/Content/animate.min.css",
                      "~/Content/bootstrap.css",
                       "~/Content/flexslider.css",
                        "~/Content/blog.css",
                        "~/Content/Admin.css",
                        "~/Content/font-awesome.css",
                        "~/Content/icon-font.min.css",
                      "~/Content/style.css"));
        }
    }
}
