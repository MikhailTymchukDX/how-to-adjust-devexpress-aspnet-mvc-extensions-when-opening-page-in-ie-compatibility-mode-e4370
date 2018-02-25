Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc
Imports DevExpress.Web.ASPxClasses.Internal
Imports DevExpress.Web.ASPxClasses

Namespace MvcGridView_example.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Protected Overrides Sub OnActionExecuted(ByVal filterContext As ActionExecutedContext)
			MyBase.OnActionExecuted(filterContext)
			If RenderUtils.Browser.IsIE Then
				ASPxWebControl.SetIECompatibilityMode(7)
				Dim IEVersion = 7
				ViewData("MetaContent") = String.Format("<meta http-equiv=""X-UA-Compatible"" content=""IE={0}"" />", IEVersion)
			End If
		End Sub

	End Class
End Namespace
