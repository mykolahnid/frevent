using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Frevent.Data.Infrastructure;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Frevent.Web.Startup))]
namespace Frevent.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}