using System.Web.Mvc;
using DevExpress.Web.Mvc;
using FileManager_Example.Helpers;

namespace FileManager_Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View();
        }
        [ValidateInput(false)]
        public ActionResult FileManagerPartial() {
            return PartialView("_FileManagerPartial", HomeControllerFileManagerSettings.Model);
        }

        public FileStreamResult FileManagerPartialDownload() {
            return FileManagerExtension.DownloadFiles(FMSettingsHelper.CreateFileManagerDownloadSettings(), HomeControllerFileManagerSettings.Model);
        }
    }
    public class HomeControllerFileManagerSettings {
        public const string RootFolder = @"~\";

        public static string Model { get { return RootFolder; } }
    }
}