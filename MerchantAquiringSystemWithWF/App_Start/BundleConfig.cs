using System.Web;
using System.Web.Optimization;

namespace MerchantAquiringSystemWithWF
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
            bundles.Add(new ScriptBundle("~/bundles/jqueryUI").Include(
                        "~/Scripts/jquery-ui-{version}.js"));
            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                      "~/Scripts/moment.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendor")
                .Include("~/node_modules/angular/angular.js",
                "~/node_modules/api-check/dist/api-check.js",
                "~/node_modules/angular-formly/dist/formly.js",
                  "~/node_modules/angular-formly/dist/formly.js",
                   "~/node_modules/angular-formly-templates-bootstrap/dist/angular-formly-templates-bootstrap.js",
                   "~/node_modules/@uirouter/angularjs/release/angular-ui-router.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/Scripts/app/app.module.js", "~/Scripts/app/app.constants.js"

                ));
            bundles.Add(new ScriptBundle("~/bundles/NewAffiliation")
               .Include("~/Views/NewAffiliation/AO/Create.component.js",
                "~/Views/NewAffiliation/AO/Index.component.js",
               "~/Views/NewAffiliation/newaffiliation.service.js",
               "~/Views/NewAffiliation/newaffiliation.route.js"

               ));

            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootswatch/materia/bootstrap.css",
                      "~/Content/themes/base/core.css",
                      "~/Content/themes/base/datepicker.css",
                      "~/Content/themes/base/jquery-ui.css",
                       "~/Content/font-awesome.css",
                      "~/Content/site.css"));
           
        }
    }
}
