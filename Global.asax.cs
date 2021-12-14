﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace TestApplication3
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Required;
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
            DevExpress.XtraReports.Web.ASPxWebDocumentViewer.StaticInitialize();
        }
    }
}