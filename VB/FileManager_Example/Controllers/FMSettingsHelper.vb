Imports DevExpress.Web

Namespace FileManager_Example.Helpers
	Public Class FMSettingsHelper
		Public Shared Function CreateFileManagerDownloadSettings() As DevExpress.Web.Mvc.FileManagerSettings
			Dim settings = New DevExpress.Web.Mvc.FileManagerSettings()
			Dim editingSettings = CreateFileManagerEditingSettings()
			settings.SettingsEditing.Assign(editingSettings)
			settings.Name = "FileManager"
			Return settings
		End Function
		Public Shared Function CreateFileManagerEditingSettings() As FileManagerSettingsEditing
			Return New FileManagerSettingsEditing(Nothing) With {
				.AllowCreate = True,
				.AllowMove = True,
				.AllowDelete = True,
				.AllowRename = True,
				.AllowCopy = True,
				.AllowDownload = True
			}
		End Function
	End Class
End Namespace