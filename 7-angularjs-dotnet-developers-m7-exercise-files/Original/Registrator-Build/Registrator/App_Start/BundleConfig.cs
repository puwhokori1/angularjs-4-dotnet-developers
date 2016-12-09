using System.Web;
using System.Web.Optimization;

namespace Registrator
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/libs").Include(
                        "~/Scripts/toastr.js"));

            bundles.Add(new ScriptBundle("~/bundles/code").IncludeDirectory(
                        "~/app/", "*.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/toastr.css",
                "~/Content/bootstrap.css",
                "~/Content/site.css"
                ));

            
        }
    }
}