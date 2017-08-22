
using Microsoft.AspNetCore.Mvc.Filters;

namespace Gsys.Mvc.Controllers.Shared
{
    public class IsAuthorize : ActionFilterAttribute
    {

        //public IsAuthorize()
        //{
        //}

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                //context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }

        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    base.OnActionExecuted(filterContext);
        //}

        //public override void OnResultExecuting(ResultExecutingContext filterContext)
        //{
        //    base.OnResultExecuting(filterContext);
        //}

        //public override void OnResultExecuted(ResultExecutedContext filterContext)
        //{
        //    base.OnResultExecuted(filterContext);
        //}
    }
}