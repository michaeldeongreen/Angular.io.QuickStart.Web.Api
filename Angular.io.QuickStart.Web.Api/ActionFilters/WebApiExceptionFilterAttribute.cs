using Angular.io.QuickStart.Web.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using Newtonsoft.Json;

namespace Angular.io.QuickStart.Web.Api.ActionFilters
{
    public class WebApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is ServiceValidationException)
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                response.Content = new StringContent(JsonConvert.SerializeObject(actionExecutedContext.Exception.Message));
                actionExecutedContext.Response = response;
            }
            else
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("HTTP 500 - Internal Server Error");
                actionExecutedContext.Response = response;
            }
        }
    }
}