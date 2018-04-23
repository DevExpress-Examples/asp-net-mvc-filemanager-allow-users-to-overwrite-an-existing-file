@Html.DevExpress().FileManager(Sub(settings)
                                   settings.Name = "fileManager"
                                   settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "FileManagerPartial"}

                                   settings.DownloadRouteValues = New With {Key .Controller = "Home", Key .Action = "FileManagerPartialDownload"}
                                   settings.SettingsToolbar.ShowDownloadButton = True
    
                                   settings.Settings.ThumbnailFolder = Url.Content("~/Content/FileManager/Thumbnails")

                                   settings.SettingsEditing.AllowCreate = True
                                   settings.SettingsEditing.AllowRename = True
                                   settings.SettingsEditing.AllowMove = True
                                   settings.SettingsEditing.AllowDelete = True
                                   settings.SettingsUpload.UseAdvancedUploadMode = True
                                   settings.SettingsUpload.AdvancedModeSettings.EnableMultiSelect = True
    
                                   settings.SettingsFileList.View = DevExpress.Web.ASPxFileManager.FileListView.Thumbnails
                                        
                                   settings.ClientSideEvents.FileUploading = "uploadStarted"
                                   settings.FileUploading = Sub(s, e)
                                                                'Comment these lines to upload the file************************
                                                                e.Cancel = True
                                                                
                                                                Throw New Exception("upload is not allowed in online examples ")
                                                                '**************************************************************

                                                                Dim isOverride As Boolean = False
                                                                Boolean.TryParse(HttpContext.Current.Request.Form("overwrite"), isOverride)
                                                                If isOverride Then
                                                                    Dim existFile = (TryCast(s, ASPxFileManager)).SelectedFolder.GetFiles().FirstOrDefault(Function(f) f.Name.Equals(e.FileName, StringComparison.InvariantCultureIgnoreCase))
                                                                    If existFile IsNot Nothing Then
                                                                        File.Delete(Path.Combine(Server.MapPath("~"), existFile.RelativeName)) ' A path depends on the RootFolder in the file manager
                                                                    End If
                                                                End If

                                                            End Sub
                                         
                               End Sub).BindToFolder(Model).GetHtml()
