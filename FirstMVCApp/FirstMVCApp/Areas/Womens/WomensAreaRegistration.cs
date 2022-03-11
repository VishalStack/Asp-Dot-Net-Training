using System.Web.Mvc;

namespace FirstMVCApp.Areas.Womens
{
    public class WomensAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Womens";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Womens_default",
                "Womens/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}