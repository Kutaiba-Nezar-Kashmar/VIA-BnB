#pragma checksum "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b3551c3461c32fa11d5b1597289a383d97e36df"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3BlazorT1Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 3 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
using SEP3BlazorT1Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
using SEP3BlazorT1Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Proof of concept</h1>\r\n");
            __builder.AddMarkupContent(1, "<span>T1 --> T2 REST API --> T3 SOAP API with Postgres DB\r\n</span>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<p>Fetched Message: </p>");
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
     if (_conceptMessage != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 15 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
        _conceptMessage.Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "Input");
            __builder.AddAttribute(7, "type", "number");
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
                                   (e) => { _id = Int32.Parse(e.Value.ToString()); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "submit");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
                                    FetchConceptMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddMarkupContent(14, "\r\n        FETCH CONCEPT MESSAGE\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\Index.razor"
 
    private int? _id;
    private ConceptMessage _conceptMessage;

    protected override async Task OnInitializedAsync()
    {
        _id = 0;
    }

    private async Task FetchConceptMessage()
    {
        int myInt = 0; 
        if (_id == null)
        {
            myInt = 0; 
        }
        else
        {
            myInt = (int) _id;
        }
       _conceptMessage = await ConceptService.getMessage(myInt);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConceptService ConceptService { get; set; }
    }
}
#pragma warning restore 1591
