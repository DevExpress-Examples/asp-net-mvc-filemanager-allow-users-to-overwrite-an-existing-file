﻿using DevExpress.Web;

namespace FileManager_Example.Helpers {
    public class FMSettingsHelper {
        public static DevExpress.Web.Mvc.FileManagerSettings CreateFileManagerDownloadSettings() {
            var settings = new DevExpress.Web.Mvc.FileManagerSettings();
            var editingSettings = CreateFileManagerEditingSettings();
            settings.SettingsEditing.Assign(editingSettings);
            settings.Name = "FileManager";
            return settings;
        }
        public static FileManagerSettingsEditing CreateFileManagerEditingSettings() {
            return new FileManagerSettingsEditing(null) {
                AllowCreate = true,
                AllowMove = true,
                AllowDelete = true,
                AllowRename = true,
                AllowCopy = true,
                AllowDownload = true
            };
        }
    }
}