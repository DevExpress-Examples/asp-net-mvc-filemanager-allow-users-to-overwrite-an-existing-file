<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552457/13.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/S37186_MVC/Controllers/HomeController.cs)
* [Global.asax](./CS/S37186_MVC/Global.asax)
* [_FileManagerPartial.cshtml](./CS/S37186_MVC/Views/Home/_FileManagerPartial.cshtml)
* [Index.cshtml](./CS/S37186_MVC/Views/Home/Index.cshtml)
<!-- default file list end -->
# FileManager - How to show a confirmation dialog to overwrite an existing file


<p>This example illustrates how to show a conformation message to overwrite an existing file in the ASPxFileManager. </p><br />
<p>The conformation message is shown in the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerScriptsASPxClientFileManager_FileUploadingtopic"><u>ASPxClientFileManager.FileUploading</u></a> event and gives an option to the user to either overwrite the existing file or cancel the operation. User's selection is then transferred to the server-side via an <a href="http://msdn.microsoft.com/en-us/library/dd492508(v=vs.100).aspx"><u>ASP.Net MVC Helper Html.Hidden</u></a>. If the user chooses to overwrite the file, the existing file will be deleted in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxFileManagerASPxFileManager_FileUploadingtopic"><u>ASPxFileManager.FileUploading</u></a> event. </p>

<br/>


