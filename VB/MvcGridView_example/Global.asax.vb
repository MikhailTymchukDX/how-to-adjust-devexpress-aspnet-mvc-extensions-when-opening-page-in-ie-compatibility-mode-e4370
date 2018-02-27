Imports System
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace MvcGridView_example
    ' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    ' visit http://go.microsoft.com/?LinkId=9394801

    Public Class MvcApplication
        Inherits System.Web.HttpApplication

        Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
            filters.Add(New HandleErrorAttribute())
        End Sub

        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

            routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.Optional}) ' Parameter defaults -  URL with parameters -  Route name

        End Sub

        Protected Sub Application_Start()
            AreaRegistration.RegisterAllAreas()

            RegisterGlobalFilters(GlobalFilters.Filters)
            RegisterRoutes(RouteTable.Routes)
        End Sub

        Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
            DevExpress.Web.ASPxClasses.ASPxWebControl.SetIECompatibilityMode(7)
        End Sub
    End Class
End Namespace