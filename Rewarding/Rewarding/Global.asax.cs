﻿using Rewarding.App_Start;
using Rewarding.Migrations;
using Rewarding.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rewarding
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundle();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PersonContext, Configuration>());
        }
    }
}
