#pragma checksum "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "913a93dc3e1b9fe7c76d5aa5527b66716a9ab690"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3BlazorT1Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatAppBarContainer>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatAppBar>(2);
                __builder2.AddAttribute(3, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatAppBarRow>(5);
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatAppBarSection>(7);
                        __builder4.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatIconButton>(9);
                            __builder5.AddAttribute(10, "Icon", "menu");
                            __builder5.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
                                                     MenuClicked

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(12, "\r\n                ");
                            __builder5.OpenComponent<MatBlazor.MatAppBarTitle>(13);
                            __builder5.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(15, "VIA BnB");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(16, "\r\n            ");
                        __builder4.OpenComponent<MatBlazor.MatAppBarSection>(17);
                        __builder4.AddAttribute(18, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatAppBarSectionAlign>(
#nullable restore
#line 31 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
                                      MatAppBarSectionAlign.End

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatButtonLink>(20);
                            __builder5.AddAttribute(21, "class", "text-white nav-link");
                            __builder5.AddAttribute(22, "Match", "NavLinkMatch.All");
                            __builder5.AddAttribute(23, "href", "/");
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(25, "\r\n                    Home\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(26, "\r\n                ");
                            __builder5.OpenComponent<MatBlazor.MatButtonLink>(27);
                            __builder5.AddAttribute(28, "class", "text-white nav-link");
                            __builder5.AddAttribute(29, "href", "/registerresidence");
                            __builder5.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(31, "\r\n                    About\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(32, "\r\n                ");
                            __builder5.OpenComponent<MatBlazor.MatButtonLink>(33);
                            __builder5.AddAttribute(34, "class", "text-white nav-link");
                            __builder5.AddAttribute(35, "href", "");
                            __builder5.AddAttribute(36, "Style", "background-color: darkred");
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(38, "\r\n                    Become Host\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    \r\n    ");
                __builder2.OpenComponent<MatBlazor.MatAppBarContent>(40);
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatDrawerContainer>(42);
                    __builder3.AddAttribute(43, "Style", "width: 100vw; height: 100vh");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatDrawer>(45);
                        __builder4.AddAttribute(46, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatDrawerMode>(
#nullable restore
#line 48 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
                                                    MatDrawerMode.Modal

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "Opened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
                                     _opened

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "OpenedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _opened = __value, _opened))));
                        __builder4.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatListGroup>(50);
                            __builder5.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MatBlazor.MatListGroupSubHeader>(52);
                                __builder6.AddAttribute(53, "Style", "margin-top: 1rem");
                                __builder6.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(55, "Manage residences");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n                ");
                                __builder6.OpenComponent<MatBlazor.MatList>(57);
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MatBlazor.MatListItem>(59);
                                    __builder7.AddAttribute(60, "Href", "/registerresidence");
                                    __builder7.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(62, "\r\n                        Register Residence\r\n                    ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(63, "\r\n                    ");
                                    __builder7.OpenComponent<MatBlazor.MatListItem>(64);
                                    __builder7.AddAttribute(65, "Href", "/buildingsoverview");
                                    __builder7.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(67, "\r\n                        Buildings overview \r\n                    ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(68, "\r\n            ");
                        __builder4.OpenComponent<MatBlazor.MatDrawerContent>(69);
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(71, "div");
                            __builder5.AddAttribute(72, "class", "container");
                            __builder5.AddAttribute(73, "b-9bhvrerbv1");
                            __builder5.AddContent(74, 
#nullable restore
#line 64 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Shark\Documents\Coding\SEP3\VIABnB-SEP3\t1\SEP3BlazorT1Client\SEP3BlazorT1Client\Shared\MainLayout.razor"
 
    private bool _opened = false;

    private void MenuClicked()
    {
        _opened = !_opened;
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
