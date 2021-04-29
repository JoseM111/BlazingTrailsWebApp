#pragma checksum "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a91c9cf1e4cc5416790cacb5da17d15b21a251"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingTrailsWebApp.Features.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using BlazingTrailsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using BlazingTrailsWebApp.Features.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using BlazingTrailsWebApp.Features.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using BlazingTrailsWebApp.Features.Home.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/_Imports.razor"
using BlazingTrailsWebApp.Features.Home.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class HomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 25 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
 if(_trails == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading trails...</p>");
#nullable restore
#line 27 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
	//☰☰☰☰☰☰☰☰☰☰
} else {
	//☰☰☰☰☰☰☰☰☰☰

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row row-cols-1 row-cols-md-2");
#nullable restore
#line 32 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
         foreach(var trail in _trails) {
			//☰☰☰☰☰☰☰☰☰☰

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col mb-4");
            __builder.OpenComponent<BlazingTrailsWebApp.Features.Home.Components.TrailCard>(5);
            __builder.AddAttribute(6, "Trail", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingTrailsWebApp.Features.Home.Models.TrailModel>(
#nullable restore
#line 35 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
                                  trail

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 37 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/josemartinez/Documents/Dotnet2021/BlazingTrailsWebApp/Features/Home/HomePage.razor"
       
	//☰☰☰☰☰☰☰☰☰☰
	private IEnumerable<TrailModel> _trails;
	
	/**━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
	<HttpClient-Blazor-Methods>:
	    • will be available as a static asset at runtime just like the CSS file,
	      this means the path we need to pass in the GET request is simply,
	      “trails/trail-data.json”. A great productivity enhancement which ships
	      with Blazor is the addition of some extension methods for the HttpClient:
			
			• GetFromJsonAsync
			• PostAsJsonAsync
			• PutAsJsonAsync

			• Under the hood, these methods are using the new System.Text.Json library.
			  The first method will deserialize a successful response containing a JSON
			  payload to a type we specify. The second and third will serialize an object
			  to JSON to be sent to the server. All three of these methods do this in a 
			  single line. No more having to manually serialized and deserialize objects or
			  check for success codes, making everything much cleaner and removing a lot of
			  boilerplate. One thing to be aware of when using these new methods is that when
			  a non-success code is returned from the server, they’ll throw an exception of type
			  HttpRequestException. This means that it’s generally a good practice to wrap these
			  calls in a try catch statement so non-success codes can be handled gracefully.
	━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━*/
	// ☰☰☰☰☰☰☰☰☰☰☰  HttpClient-Methods  ☰☰☰☰☰☰☰☰☰☰☰
	protected override async Task OnInitializedAsync() {
	//☰☰☰☰☰☰☰☰☰☰
		try {
			_trails = await Http.GetFromJsonAsync<IEnumerable<TrailModel>>(
				"data/trail-data.json"
				);
	//☰☰☰☰☰☰☰☰☰☰
		} catch(HttpRequestException e) {
			Console.WriteLine(
				$"There was a problem loading trail data: {e.Message}"
				);
		}
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591