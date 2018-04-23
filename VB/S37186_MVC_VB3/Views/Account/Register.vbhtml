@ModelType S37186_MVC_VB3.RegisterModel

<div class="accountHeader">
    <h2>
        Create a New Account</h2>
    <p>Use the form below to create a new account.</p>
	</div>
@Using Html.BeginForm()
	    @Html.AntiForgeryToken()
        @Html.DevExpress().Label(Sub(settings)
		settings.Name = "UserNameLabel"
		settings.Text = "User Name"
		settings.AssociatedControlName = "UserName"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.UserName)
        @Html.ValidationMessageFor(Function(m) m.UserName)
    </div>
    @Html.DevExpress().Label(Sub(settings)
		settings.Name = "EmailLabel"
		settings.Text = "Email"
		settings.AssociatedControlName = "Email"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.Email)
        @Html.ValidationMessageFor(Function(m) m.Email)
    </div>
    @Html.DevExpress().Label(Sub(settings)
		settings.Name = "PasswordLabel"
		settings.Text = "Password"
		settings.AssociatedControlName = "Password"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.Password)
        @Html.ValidationMessageFor(Function(m) m.Password)
    </div>
    @Html.DevExpress().Label(Sub(settings)
		settings.Name = "ConfirmPasswordLabel"
		settings.Text = "Confirm Password"
		settings.AssociatedControlName = "ConfirmPassword"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.ConfirmPassword)
        @Html.ValidationMessageFor(Function(m) m.ConfirmPassword)
    </div>
    @Html.DevExpress().Button(Sub(settings)
		settings.Name = "Button"
		settings.Text = "Register"
		settings.UseSubmitBehavior = True
	End Sub).GetHtml()
End Using