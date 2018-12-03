using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Microsoft.AspNetCore.Routing;

namespace RadyoFiratUniversite.RadyoFirat.WebUI.Filters
{
    public class AuthFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("kullaniciAdi")==null)
            {
                context.Result=new RedirectToActionResult("Index","Home",true);
                return;
            }
            
        }
    }
}
