@model S37186_MVC_VB3.Models.ChangePasswordModel

<div class="accountHeader">
    <h2>
        Change Password</h2>
    <p>Use the form below to change your password.</p>
	</div>
@Using Html.BeginForm()
	    @Html.AntiForgeryToken()
        @Html.DevExpress().Label(Sub(settings)
		settings.Name = "OldPasswordLabel"
		settings.Text = "Old Password"
		settings.AssociatedControlName = "OldPassword"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.OldPassword)
        @Html.ValidationMessageFor(Function(m) m.OldPassword)
    </div>
                
    @Html.DevExpress().Label(Sub(settings)
		settings.Name = "NewPasswordLabel"
		settings.Text = "New Password"
		settings.AssociatedControlName = "NewPassword"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.NewPassword)
        @Html.ValidationMessageFor(Function(m) m.NewPassword)
    </div>
                
    @Html.DevExpress().Label(Sub(settings)
		settings.Name = "ConfirmPasswordLabel"
		settings.Text = "Confirm Password"
		settings.AssociatedControlName = "ConfirmPassword"
	End Sub).GetHtml()
    @<div class="editor-field">
        @Html.EditorFor(Function(m) m.ConfirmPassword)
        @Html.ValidationMessageFor(Function(m) m.ConfirmPassword)
    </div>
    
    @Html.DevExpress().Button(Sub(settings)
		settings.Name = "Button"
		settings.Text = "Change Password"
		settings.UseSubmitBehavior = True
	End Sub).GetHtml()
End Using