using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Services
{
    public class ServiceValidationException : Exception
    {
        public ServiceValidationException(string message) : base(message)
        {
        }
    }
}
