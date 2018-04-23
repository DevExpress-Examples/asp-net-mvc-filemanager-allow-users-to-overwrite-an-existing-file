<script type="text/javascript">
    function uploadStarted(s, e) {
        var fileNames = e.fileName.split(", ");
        var existsFiles = fileManager.GetItems();

        var founded = [];

        for (var i = 0; i < existsFiles.length; i++) {
            var ef = existsFiles[i];
            for (var j = 0; j < fileNames.length; j++) {
                if (ef.name.toLowerCase() == fileNames[j].toLowerCase())
                    founded.push(ef.name);
            }
        }
        if (founded.length > 0) {
            if (confirm("Overwrite " + founded.length + " files?")) {
                document.getElementById('overwrite').value = true;
                return
            }
            e.cancel = true;
        }
        document.getElementById('overwrite').value = false;
    }
</script>

@Using (Html.BeginForm("FileManagerForm", "UploadControl", FormMethod.Post))
    @Html.Hidden("overwrite")
    @Html.Action("FileManagerPartial")
End Using
