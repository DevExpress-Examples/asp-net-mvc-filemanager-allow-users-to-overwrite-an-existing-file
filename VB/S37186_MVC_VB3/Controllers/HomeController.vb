Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace S37186_MVC_VB3.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
            Return View()
        End Function
        <ValidateInput(False)> _
        Public Function FileManagerPartial() As ActionResult
            Return PartialView("_FileManagerPartial", HomeControllerFileManagerSettings.Model)
        End Function

        Public Function FileManagerPartialDownload() As FileStreamResult
            Return FileManagerExtension.DownloadFiles("FileManager", HomeControllerFileManagerSettings.Model)
        End Function
    End Class
    Public Class HomeControllerFileManagerSettings
        Public Const RootFolder As String = "~\"

        Public Shared ReadOnly Property Model() As String
            Get
                Return RootFolder
            End Get
        End Property
    End Class


End Namespace
