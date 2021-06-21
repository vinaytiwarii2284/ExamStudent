using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Configuration;

namespace ExamStudent.Controllers
{
    public class BaseController : Controller
    {
        #region Overriden Methods
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //string actionKey = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
            //                         "-" + filterContext.ActionDescriptor.ActionName;
            //if (Session[Constants.SESSION_USERID] == null && !actionKey.Equals("Home-Index") && !actionKey.Equals("Account-Login")
            //     && !actionKey.Equals("Home-PreLogin"))
            //    filterContext.Result = RedirectToAction("Login", "Account");

            //ApplicationUser user = (ApplicationUser)Session[Constants.SESSION_CURRENT_USER];
            //string actionKey = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
            //                        "-" + filterContext.ActionDescriptor.ActionName;
            //if (user != null & !actionKey.Equals("Home-AccessDenied") && !actionKey.Equals("Account-Login"))
            //{
            //    List<string> allowedActions = new List<string>();
            //    List<string> userRoles = new List<string>();




            //    if (Session[Constants.SESSION_CURRENT_ROLES] == null)
            //    {
            //        userRoles = realStateDbContext.AspNetUserRoles
            //                    .Where(u => u.UserId == user.Id)
            //                    .Select(t => t.RoleId).ToList();

            //        Session[Constants.SESSION_CURRENT_ROLES] = userRoles;
            //    }
            //    else
            //    {
            //        userRoles = (List<string>)Session[Constants.SESSION_CURRENT_ROLES];
            //    }

            //    if (Session[Constants.SESSION_AUTHORIZED_MODULES] == null)
            //    {
            //        userRoles.ToList().ForEach(role => allowedActions.AddRange(GetUserAuthorizedRoleActivities(role)));
            //        Session[Constants.SESSION_AUTHORIZED_MODULES] = allowedActions;
            //    }
            //    else
            //    {
            //        allowedActions = (List<string>)Session[Constants.SESSION_AUTHORIZED_MODULES];
            //    }

            //    if (allowedActions.Any(s => s.Equals(actionKey, StringComparison.OrdinalIgnoreCase)))
            //    {
            //        if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            //        {
            //            filterContext.Result = new RedirectToRouteResult(
            //                    new RouteValueDictionary { { "controller", "Account" }, { "action", "Login" } });
            //        }
            //    }
            //    else
            //    {
            //        filterContext.Result = RedirectToAction("AccessDenied", "Home");   //( RedirectToAction("NoAccessRight");
            //    }
            //}


        }

        protected override void OnException(ExceptionContext filterContext)
        {           
            if (filterContext != null && filterContext.Exception != null)
            {

                string controller = filterContext.RouteData.Values["controller"].ToString();
                string action = filterContext.RouteData.Values["action"].ToString();
                string loggerName = string.Format("{0}Controller.{1}", controller, action);

                // Output a nice error page
                if (filterContext.HttpContext.IsCustomErrorEnabled)
                {
                    filterContext.ExceptionHandled = true;
                    HandleErrorInfo errorInfo = new HandleErrorInfo(filterContext.Exception, controller, action);
                    this.View("Error", errorInfo);//.ExecuteResult(this.ControllerContext);
                    ViewBag.WebUrl = ConfigurationManager.AppSettings["WebsiteUrl"].ToString();
                }
            }
            
        }
        #endregion
    }
}