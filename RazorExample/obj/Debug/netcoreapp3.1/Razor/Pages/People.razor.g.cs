#pragma checksum "/Users/vimalraveendran/Projects/RazorExample/RazorExample/Pages/People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624897521f6795be620ab2c60200c7d4da80ca15"
// <auto-generated/>
#pragma warning disable 1591
namespace RazorExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using RazorExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/_Imports.razor"
using RazorExample.Shared;

#line default
#line hidden
#nullable disable
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"bg-info text-white\">People</h1>\n\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.AddMarkupContent(4, "<label>Name:</label>\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 27 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/Pages/People.razor"
                                                    Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/vimalraveendran/Projects/RazorExample/RazorExample/Pages/People.razor"
       

    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }


    }

    // component parameter recieved from the parent component
    [Parameter]
    public string Name { get; set; }

    [Parameter]

    public string Value { get; set; }

    // person property of People class
    public Person person { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
