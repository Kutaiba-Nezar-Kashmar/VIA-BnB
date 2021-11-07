// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP3BlazorT1Client.Pages.BuildingsOverview
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using SEP3BlazorT1Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using SEP3BlazorT1Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
using SEP3BlazorT1Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BuildingsOverview")]
    public partial class BuildingsOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\BuildingsOverview\BuildingsOverview.razor"
       

    Residence[] Residences = new[]
    {
        new Residence
        {
            Id = 1,
            Address = new Address()
            {
                Id = 1,
                StreetName = "Sally",
                HouseNumber = "2",
                CityName = "Horsens",
                StreetNumber = "3b",
                ZipCode = 8700,
            },
            Description = "beautiful house full of cats!",
            Type = "villa",
            AverageRating = 2,
            IsAvailable = false,
            PricePerNight = 1000,
            Rules = new List<Rule>(),
            Facilities = new List<Facility>(),
            ImageUrl = "https://static.dezeen.com/uploads/2020/02/house-in-the-landscape-niko-arcjitect-architecture-residential-russia-houses-khurtin_dezeen_2364_hero-852x479.jpg"
        },

        new Residence
        {
            Id = 2,
            Address = new Address()
            {
                Id = 2,
                StreetName = "Reshee",
                HouseNumber = "B",
                CityName = "Horsens",
                StreetNumber = "A1",
                ZipCode = 8700,
            },
            Description = "amazing house full of flowers and books",
            Type = "house",
            AverageRating = 1,
            IsAvailable = false,
            PricePerNight = 1000,
            Rules = new List<Rule>(),
            Facilities = new List<Facility>(),
            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQyXb58B6PUsT9t0EfH8zKpl_An5h0ssJhZnw&usqp=CAU"
        },
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591