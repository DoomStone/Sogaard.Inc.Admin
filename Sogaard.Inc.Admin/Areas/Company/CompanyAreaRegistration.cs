using System.Web.Mvc;

namespace Sogaard.Inc.Admin.Areas.Company
{
    public class CompanyAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Company";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Company_default",
                "Company/{siteid}/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new { siteid = @"\d+" },
                new[] { "Sogaard.Inc.Admin.Areas.Company.Controllers" }
            );
        }
    }
}
