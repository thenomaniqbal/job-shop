using System.Web;
using System.Web.Optimization;

namespace JobShop
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


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));


            bundles.Add(new StyleBundle("~/login/css").Include(
                     "~/Content/login/bootstrap/dist/css/bootstrap.min.css",
                     "~/Content/login/dist/css/AdminLTE.min.css",
                     "~/Content/login/plugins/iCheck/square/blue.css",
                    "~/Content/login/font-awesome/css/font-awesome.min.css",
                     "~/Content/login/Ionicons/css/ionicons.min.css"));


            bundles.Add(new ScriptBundle("~/login/js").Include(
                      "~/Content/login/jquery/dist/jquery.min.js",
                      "~/Content/login/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/login/plugins/iCheck/icheck.min.js"));


        }
    }
}
