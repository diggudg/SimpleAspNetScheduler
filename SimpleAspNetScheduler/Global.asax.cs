using SimpleAspNetScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SimpleAspNetScheduler
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //private static CacheItemRemovedCallback OnCacheRemove = null;
        protected void Application_Start()
        {
          //  SomeScheduler.Start();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SomeScheduler.Start();
           // AddTask("DoStuff", 60);
            // Utilities.WriteLog();
        }
        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    SomeScheduler.Start();
        //}
        //private void AddTask(string name, int seconds)
        //{
        //    //OnCacheRemove = new CacheItemRemovedCallback(CacheItemRemoved);
        //    //HttpRuntime.Cache.Insert(name, seconds, null,
        //    //    DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration,
        //    //    CacheItemPriority.NotRemovable, OnCacheRemove);
        //    Utilities.WriteLog("AddTask Has been started");
        //}

        //public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
        //{
        //    // do stuff here if it matches our taskname, like WebRequest
        //    // re-add our task so it recurs
        //    AddTask(k, Convert.ToInt32(v));
        //}
    }
}
