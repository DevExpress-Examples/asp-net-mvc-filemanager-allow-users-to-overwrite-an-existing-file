@ModelType S37186_MVC_VB3.LoginModel

<div class="accountHeader">
    <h2>
        Log In</h2>
    <p>
        Please enter your username and password. @Html.ActionLink("Register", "Register")
        if you don't have an account.</p>
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
		settings.Name = "PasswordLabel"
		settings.Text = "Password"
		settings.AssociatedControlName = "Password"
	End Sub).GetHtml()
    @<div class="form-field">
        @Html.EditorFor(Function(m) m.Password)
        @Html.ValidationMessageFor(Function(m) m.Password)
    </div>

    @<div class="form-field">
        @Html.DevExpress().CheckBox(Sub(settings)
			settings.Name = "RememberMe"
			settings.Text = "Remember me?"
		End Sub).GetHtml()
    </div>

    @Html.DevExpress().Button(Sub(settings)
		settings.Name = "Button"
		settings.Text = "Log On"
		settings.UseSubmitBehavior = True
	End Sub).GetHtml()
End Using