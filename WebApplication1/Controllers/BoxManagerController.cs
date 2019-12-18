using BoxManager.BS;
using BoxManager.BS.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BoxManagerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var loginService = new LoginService();
            var tenantId = loginService.Login(model);

            Session["TenantId"] = tenantId;

            if (tenantId != -1) 
            {                
                return Redirect(model.ReturnUrl);
            }

            return View(model);
        }

        public ActionResult Wod() 
        {
            var tiposConteoService = new TipoConteoService();
            var nivelesService = new NivelService();
            var tenantId = Session["TenantId"] != null ? (int)Session["TenantId"] : -1;

            var model = new WodModel()
            {
                Niveles = nivelesService.GetByTenantId(tenantId),
                TiposConteo = tiposConteoService.GetByTenantId(tenantId)
            };
            return View(model);
        }

        public ActionResult GuardarWod(WodModel model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var tenantId = Session["TenantId"] != null ? (int)Session["TenantId"] : -1;
            model.IdTenant = tenantId;

            var wodService = new WodService();
            wodService.Insert(model);

            return Redirect(model.ReturnUrl);
        }
    }
}