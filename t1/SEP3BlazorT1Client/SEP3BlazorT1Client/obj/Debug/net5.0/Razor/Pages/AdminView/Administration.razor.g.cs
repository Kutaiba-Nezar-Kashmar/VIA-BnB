#pragma checksum "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d59b9496f7b851efb813a1b3db043517beba04c9"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3BlazorT1Client.Pages.AdminView
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
#line 11 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
using SEP3BlazorT1Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatTabGroup>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatTab>(2);
                __builder2.AddAttribute(3, "Label", "Hosts Requests");
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
             if (hostRequestList == null)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(5, "<p>Nothing to show</p>");
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MatBlazor.MatAccordion>(6);
                    __builder3.AddAttribute(7, "Multi", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                     foreach (var h in hostRequestList)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MatBlazor.MatExpansionPanel>(9);
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatExpansionPanelSummary>(11);
                            __builder5.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MatBlazor.MatExpansionPanelHeader>(13);
                                __builder6.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenElement(15, "p");
                                    __builder7.AddContent(16, 
#nullable restore
#line 19 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                        h.Id

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(17, "\r\n                            ");
                            __builder5.OpenComponent<MatBlazor.MatExpansionPanelDetails>(18);
                            __builder5.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(20, "div");
                                __builder6.AddAttribute(21, "class", "form-group");
                                __builder6.OpenElement(22, "p");
                                __builder6.AddContent(23, "Host ID: ");
                                __builder6.AddContent(24, 
#nullable restore
#line 23 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                 h.Id

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(25, "\r\n                                ");
                                __builder6.OpenElement(26, "div");
                                __builder6.AddAttribute(27, "class", "form-group");
                                __builder6.OpenElement(28, "p");
                                __builder6.AddContent(29, "First Nmae: ");
                                __builder6.AddContent(30, 
#nullable restore
#line 25 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                    h.FirstName

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(31, "\r\n                                ");
                                __builder6.OpenElement(32, "div");
                                __builder6.AddAttribute(33, "class", "form-group");
                                __builder6.OpenElement(34, "p");
                                __builder6.AddContent(35, "Last Name: ");
                                __builder6.AddContent(36, 
#nullable restore
#line 27 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                   h.LastName

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(37, "\r\n                                ");
                                __builder6.OpenElement(38, "div");
                                __builder6.AddAttribute(39, "class", "form-group");
                                __builder6.OpenElement(40, "p");
                                __builder6.AddContent(41, "Phone Number: ");
                                __builder6.AddContent(42, 
#nullable restore
#line 29 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                      h.PhoneNumber

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(43, "\r\n                                ");
                                __builder6.OpenElement(44, "div");
                                __builder6.AddAttribute(45, "class", "form-group");
                                __builder6.OpenElement(46, "p");
                                __builder6.AddContent(47, "E-mail Address: ");
                                __builder6.AddContent(48, 
#nullable restore
#line 31 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                        h.Email

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(49, "\r\n                                ");
                                __builder6.OpenElement(50, "div");
                                __builder6.AddAttribute(51, "class", "form-group");
                                __builder6.OpenElement(52, "p");
                                __builder6.AddContent(53, "CPR-Number: ");
                                __builder6.AddContent(54, 
#nullable restore
#line 33 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                    h.Cpr

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(55, "\r\n                                ");
                                __builder6.OpenElement(56, "div");
                                __builder6.AddAttribute(57, "class", "form-group");
                                __builder6.OpenElement(58, "div");
                                __builder6.AddAttribute(59, "class", "row");
                                __builder6.OpenElement(60, "div");
                                __builder6.AddAttribute(61, "class", "col-md-6");
                                __builder6.OpenElement(62, "button");
                                __builder6.AddAttribute(63, "class", "btn btn-outline-dark");
                                __builder6.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                                                           (()=> ApproveHost(h.Id))

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddContent(65, "Approve");
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(66, "\r\n                                            ");
                                __builder6.OpenElement(67, "button");
                                __builder6.AddAttribute(68, "class", "btn btn-outline-dark");
                                __builder6.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                                                           (()=> RejectHost(h.Id))

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddContent(70, "Reject");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 44 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 46 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatTab>(72);
                __builder2.AddAttribute(73, "Label", "Guests Requests");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 51 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
             if (guestRequestList == null)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(75, "<p>Nothing to show</p>");
#nullable restore
#line 54 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MatBlazor.MatAccordion>(76);
                    __builder3.AddAttribute(77, "Multi", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 58 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                     foreach (var g in guestRequestList)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MatBlazor.MatExpansionPanel>(79);
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatExpansionPanelSummary>(81);
                            __builder5.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MatBlazor.MatExpansionPanelHeader>(83);
                                __builder6.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenElement(85, "p");
                                    __builder7.AddContent(86, 
#nullable restore
#line 63 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                        g.Id

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(87, "\r\n                            ");
                            __builder5.OpenComponent<MatBlazor.MatExpansionPanelDetails>(88);
                            __builder5.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(90, "div");
                                __builder6.AddAttribute(91, "class", "form-group");
                                __builder6.OpenElement(92, "p");
                                __builder6.AddContent(93, "Guest ID: ");
                                __builder6.AddContent(94, 
#nullable restore
#line 67 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                  g.Id

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(95, "\r\n                                ");
                                __builder6.OpenElement(96, "div");
                                __builder6.AddAttribute(97, "class", "form-group");
                                __builder6.OpenElement(98, "p");
                                __builder6.AddContent(99, "First Nmae: ");
                                __builder6.AddContent(100, 
#nullable restore
#line 69 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                    g.FirstName

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(101, "\r\n                                ");
                                __builder6.OpenElement(102, "div");
                                __builder6.AddAttribute(103, "class", "form-group");
                                __builder6.OpenElement(104, "p");
                                __builder6.AddContent(105, "Last Name: ");
                                __builder6.AddContent(106, 
#nullable restore
#line 71 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                   g.LastName

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(107, "\r\n                                ");
                                __builder6.OpenElement(108, "div");
                                __builder6.AddAttribute(109, "class", "form-group");
                                __builder6.OpenElement(110, "p");
                                __builder6.AddContent(111, "Phone Number: ");
                                __builder6.AddContent(112, 
#nullable restore
#line 73 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                      g.PhoneNumber

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(113, "\r\n                                ");
                                __builder6.OpenElement(114, "div");
                                __builder6.AddAttribute(115, "class", "form-group");
                                __builder6.OpenElement(116, "p");
                                __builder6.AddContent(117, "E-mail Address: ");
                                __builder6.AddContent(118, 
#nullable restore
#line 75 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                        g.Email

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(119, "\r\n                                ");
                                __builder6.OpenElement(120, "div");
                                __builder6.AddAttribute(121, "class", "form-group");
                                __builder6.OpenElement(122, "p");
                                __builder6.AddContent(123, "VIA-ID: ");
                                __builder6.AddContent(124, 
#nullable restore
#line 77 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                g.ViaId

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(125, "\r\n                                ");
                                __builder6.OpenElement(126, "div");
                                __builder6.AddAttribute(127, "class", "form-group");
                                __builder6.OpenElement(128, "div");
                                __builder6.AddAttribute(129, "class", "row");
                                __builder6.OpenElement(130, "div");
                                __builder6.AddAttribute(131, "class", "col-md-6");
                                __builder6.OpenElement(132, "button");
                                __builder6.AddAttribute(133, "class", "btn btn-outline-dark");
                                __builder6.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                                                           (()=> ApproveGuest(g.Id))

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddContent(135, "Approve");
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(136, "\r\n                                            ");
                                __builder6.OpenElement(137, "button");
                                __builder6.AddAttribute(138, "class", "btn btn-outline-dark");
                                __builder6.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                                                                                           (()=> RejectGuest(g.Id))

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddContent(140, "Reject");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 88 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 90 "C:\Users\Micha\Documents\Coding\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Pages\AdminView\Administration.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
