using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular.io.QuickStart.Web.Api.Common
{
    public static class Paths
    {
        public static string WebApiDocumentationXmlFilePath()
        {
            return System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/XmlDocument.xml");
        }
    }
}