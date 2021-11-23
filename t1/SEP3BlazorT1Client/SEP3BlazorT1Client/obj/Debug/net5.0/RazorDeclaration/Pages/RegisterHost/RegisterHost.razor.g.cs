// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP3BlazorT1Client.Pages.RegisterHost
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using SEP3BlazorT1Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using SEP3BlazorT1Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\RegisterHost\RegisterHost.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\RegisterHost\RegisterHost.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\RegisterHost\RegisterHost.razor"
using SEP3BlazorT1Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\RegisterHost\RegisterHost.razor"
using SEP3BlazorT1Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegisterHost")]
    public partial class RegisterHost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\RegisterHost\RegisterHost.razor"
       
    private string _errorText;
    private string _passwordConfirmation;
    private Host _newHost = new Host();
    private ICollection<ValidationResult> validationResults = new List<ValidationResult>();

    private async void CreateHost()
    {
        //clear error messages
        validationResults.Clear();
        // the validator validates in hte context of a host object
        ValidationContext validationContext = new ValidationContext(_newHost);
        
        //validates all host properties in context of host model
        bool hostIsValid = Validator.TryValidateObject(_newHost, validationContext, validationResults, true);
        

        //checks if passwords match
        if (!PasswordConfirmationMatches())
        {
            _errorText = "Passwords does not match";
            return;
        }

        if (hostIsValid)
        {
            try
            {
        //Throws exception if user already exists.
                await _hostservice.RegisterHostAsync(_newHost);
            }
            catch (Exception e)
            {
                _errorText = e.Message;
                StateHasChanged();
                return;
            }
            //User is logged on upon successful account creation
    //   await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(_newUser.Username, _newUser.Password);
            NavigationManager.NavigateTo("/");
        }
    }

    private bool PasswordConfirmationMatches()
    {
        if (_passwordConfirmation==null)
        {
            _errorText = "Please confirm password";
        }
        return _passwordConfirmation == _newHost.Password;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHostService _hostservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
