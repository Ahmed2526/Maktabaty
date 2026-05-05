using Microsoft.AspNetCore.Mvc.Filters;

namespace Maktabaty.Custom_Attributes
{
    public class AjaxOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Headers["X-Requested-With"].Equals("XMLHttpRequest"))
            {
                context.Result = new Microsoft.AspNetCore.Mvc.BadRequestResult();
            }
        }
    }
}

