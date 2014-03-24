using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Agency_ICP
{
    using Agency_ICP.App_Start;
    using System.Text;
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        /// <summary>
        /// 异常捕获
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {

            Exception ex = this.Context.Server.GetLastError();
            if (ex != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<b>系统出现如下错误：</b><br/><br/>");
                sb.Append("<b>发生时间：</b>&nbsp;&nbsp;" + DateTime.Now.ToString() + "<br/><br/>");
                sb.Append("<b>错误描述：</b>&nbsp;&nbsp;" + ex.Message.Replace("\r\n", "") + "<br/><br/>");
                sb.Append("<b>错误对象：</b>&nbsp;&nbsp;" + ex.Source + "<br/><br/>");
                sb.Append("<b>错误页面：</b>&nbsp;&nbsp;" + HttpContext.Current.Request.Url + "<br/><br/>");
                sb.Append("<b>浏览器IE：</b>&nbsp;&nbsp;" + HttpContext.Current.Request.UserAgent + "<br/><br/>");
                sb.Append("<b>服务器IP：</b>&nbsp;&nbsp;" + HttpContext.Current.Request.ServerVariables.Get("Local_Addr").ToString() + "<br/><br/>");
                sb.Append("<b>方法名称：</b>&nbsp;&nbsp;" + ex.TargetSite.ToString() + "<br/><br/>");
                sb.Append("<b>C#类名称：</b>&nbsp;&nbsp;" + ex.TargetSite.DeclaringType.ToString() + "<br/><br/>");
                sb.Append("<b>成员变量：</b>&nbsp;&nbsp;" + ex.TargetSite.MemberType.ToString() + "<br/><br/>");
                Server.ClearError();

                HttpContext.Current.Request.Cookies.Add(new HttpCookie("Http_Errors", sb.ToString()) { Domain = HttpContext.Current.Request.UserHostAddress,Expires = DateTime.Now.AddDays(7)});

                System.Web.HttpContext.Current.Response.Redirect("/Error/Index");
            }
        }

    }
}