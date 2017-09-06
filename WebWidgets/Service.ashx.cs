using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWidgets
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    public class Service : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("<h1>Hello From Service</h1>");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}