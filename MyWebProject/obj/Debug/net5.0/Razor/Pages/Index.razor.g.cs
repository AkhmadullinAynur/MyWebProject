#pragma checksum "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e815d2cfe5d15bda7ac2c2ab0def788f255c97c3"
// <auto-generated/>
#pragma warning disable 1591
namespace MyWebProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using MyWebProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using MyWebProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using MyWebProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using MyWebProject.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\Documents\MyWebProject\MyWebProject\_Imports.razor"
using MyWebProject.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
 if (!AuthorizationIsActive)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal-body");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-responsive-md");
            __builder.AddMarkupContent(4, "<thead class=\"table-dark\"><tr><th><h2>Authorization</h2></th></tr></thead>\r\n            ");
            __builder.OpenElement(5, "tbody");
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Login");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                                                                                     _login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _login = __value, _login));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "type", "password");
            __builder.AddAttribute(19, "placeholder", "Password");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                                                                                                        _password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "tr");
            __builder.OpenElement(24, "th");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-dark");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                                                               AuthorizationNow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Log in");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-dark");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                                                               NewAuthorization

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "New registration");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                 if (_isComplete)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<tr><td class=\"alert-danger\"><h3>Authorization succesfull done!</h3></td></tr>");
#nullable restore
#line 29 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                 if (_adminMode)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<tr><td class=\"alert-danger\"><h3>You are logged in as an administrator.</h3></td></tr>");
#nullable restore
#line 35 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                 if (_isNotComplete)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<tr><td class=\"alert-danger\"><h3>Authorization failed!</h3></td></tr>");
#nullable restore
#line 41 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
 if (LogInIsActive)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MyWebProject.Shared.ProjectTable>(37);
            __builder.CloseComponent();
#nullable restore
#line 50 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
 if (RegistrationIsActive)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MyWebProject.Shared.Registration>(38);
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
 if (AdminIsActive)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MyWebProject.Shared.Admin>(39);
            __builder.CloseComponent();
#nullable restore
#line 58 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\user\Documents\MyWebProject\MyWebProject\Pages\Index.razor"
       
    [Parameter]
    public bool AuthorizationIsActive { get; set; }
    [Parameter]
    public bool RegistrationIsActive { get; set; }
    [Parameter]
    public bool LogInIsActive { get; set; }
    [Parameter]
    public bool AdminIsActive { get; set; }


    private bool _isComplete;
    private bool _isNotComplete;
    private bool _adminMode;

    private List<User> users= MongoDataBase.GetUser(_login, _password);


    //[Parameter]
    //public bool UserMode { get; set; }

    private static string _login;
    private static string _password;


    private void LogIn()
    {
        _isComplete = !_isComplete;
    }

    private void AuthorizationNow()                    //<==Переделать
    {
        if (_isComplete)
        {
            _isComplete = true;
            _isNotComplete = false;
            AuthorizationIsActive = !AuthorizationIsActive;
            LogInIsActive = !LogInIsActive;

        }
        else
        if (_login == "Admin" && _password == "admin")
        {
            _isComplete = true;
            _adminMode = true;
            _isNotComplete = false;
            AuthorizationIsActive = !AuthorizationIsActive;
            AdminIsActive = !AdminIsActive;

        }
        else
        {
            _isNotComplete = true;
            _isComplete = false;
        }
    }
    private void AdminClick()
    {

    }
    private void NewAuthorization()
    {
        AuthorizationIsActive = !AuthorizationIsActive;
        RegistrationIsActive = !RegistrationIsActive;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591