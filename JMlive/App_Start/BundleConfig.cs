using System.Web.Optimization;

namespace JMlive
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            //
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularroute").Include(
                        "~/Scripts/angular-route.js"));


            bundles.Add(new ScriptBundle("~/bundles/angular-resource").Include(
                        "~/Scripts/angular-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-animate").Include(
                         "~/Scripts/angular-animate.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include("~/Scripts/angular-ui/ui-bootstrap.min.js"));

            //TODO: Move dynamic read code to framework 
            const string App = "~/App",
                common = "~/App/Common";

            bundles.Add(new ScriptBundle("~/bundles/App/js").IncludeDirectory(App, "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/App/Common/js").IncludeDirectory(common, "*.js", true));
            //bundles.Add(new ScriptBundle("~/bundles/Apps").Include(
            //            "~/App/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/themes/sample/css").Include("~/Content/themes/sample/main.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome/css").Include("~/Content/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/weather-icons/css").Include("~/Content/weather-icons/css/weather-icons.min.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
