using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DigiCartClient.Middlewares
{
    public class TeapotMiddleware : OwinMiddleware
    {
        public TeapotMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public async override Task Invoke(IOwinContext context)
        {
            context.Response.StatusCode = 418;
           await this.Next.Invoke(context);
        }
    }
}