using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Frevent.Data.Infrastructure;
using Frevent.Data.Repositories;
using Frevent.Service;
using Frevent.Web.Mappings;

namespace Frevent.Web.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            //Configure AutoMapper
            AutoMapperConfiguration.Configure();
        }
    }
}