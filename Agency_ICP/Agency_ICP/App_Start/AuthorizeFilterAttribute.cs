using System.Web.Mvc;
using System;
using System.Collections.Generic;

namespace Agency_ICP.App_Start
{
    public class AuthorizeFilterAttribute : ActionFilterAttribute
    {
        
        public string Message { get; set; }

        //在Action执行之后执行
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            
        }

        //在Action执行前执行
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            /*
            #region   
            //权限拦截是否忽略
            bool IsIgnored = false;
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            var path = filterContext.HttpContext.Request.Path.ToLower();
            //获取当前配置保存起来的允许页面
            IList<string> allowPages = ConfigSettings.GetAllAllowPage();
            foreach (string page in allowPages)
            {
                if (page.ToLower() == path)
                {
                    IsIgnored = true;
                    break;
                }
            }
            if (IsIgnored)
                return;
            //接下来进行权限拦截与验证
            object[] attrs = filterContext.ActionDescriptor.GetCustomAttributes(typeof(ViewPageAttribute), true);
            var isViewPage = attrs.Length == 1;//当前Action请求是否为具体的功能页

            if (this.AuthorizeCore(filterContext) == false)//根据验证判断进行处理
            {
                //注：如果未登录直接在URL输入功能权限地址提示不是很友好；如果登录后输入未维护的功能权限地址，那么也可以访问，这个可能会有安全问题
                if (isViewPage == true)
                {
                    //跳转到登录页面
                    filterContext.RequestContext.HttpContext.Response.Redirect("~/Admin/Manage/UserLogin");
                }
                else
                {
                    object[] attrsUIException = filterContext.ActionDescriptor.GetCustomAttributes(typeof(LigerUIExceptionResultAttribute), true);
                    if (attrsUIException.Length == 1)
                    {
                        filterContext.Result = new JsonResult() { Data = new { IsError = true, Message = "您没有权限执行此操作！" }, ContentType = "application/json; charset=UTF-8" };//功能权限弹出提示框
                    }
                    else

                        filterContext.RequestContext.HttpContext.Response.Redirect("~/Admin/Manage/Error");
                }
            }
            #endregion
            */
        }

        //在Result执行之后 
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

        //在Result执行之前
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //filterContext.HttpContext.Response.Write(@"<br />Before ViewResult Excute" + "\t " + Message);
            //base.OnResultExecuting(filterContext);
        }



    }
}