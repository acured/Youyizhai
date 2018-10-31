using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace YouyizhaiWebService.Controllers
{
    public class ResouceController : ApiController
    {
        public void PostHomeSourceList()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostSourceDetails()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostPreOrderSource()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostOrderSource()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostReleaseSource()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostAddSource()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostUpdateSource()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        public void PostDeleteSource()
        {
            ResponseMsg("{\"status\":\"ok\"}");
        }

        private void ResponseMsg(object msg)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.AddHeader("Content-type", "text/plain");
            HttpContext.Current.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            HttpContext.Current.Response.Write(msg);
            HttpContext.Current.Response.End();
        }
    }
}
