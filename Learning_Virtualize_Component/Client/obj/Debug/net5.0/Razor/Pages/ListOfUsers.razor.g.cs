#pragma checksum "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\Pages\ListOfUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d36f9ee6784994e7917fbdc9e456f5e7990ff1af"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listOfUsers")]
    public partial class ListOfUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Client.Pages.ListOfUsers.TypeInference.CreateVirtualize_0(__builder, 0, 1, 
#nullable restore
#line 23 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\Pages\ListOfUsers.razor"
                           LoadVisibleUsers

#line default
#line hidden
#nullable disable
            , 2, (user) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "style", "height: 50px;margin: 10px");
                __builder2.OpenElement(5, "a");
                __builder2.AddAttribute(6, "href");
                __builder2.AddAttribute(7, "class", "list-group-item flex-column align-items-start bold-text");
                __builder2.AddContent(8, 
#nullable restore
#line 27 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\Pages\ListOfUsers.razor"
                 user.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, " ");
                __builder2.AddContent(10, 
#nullable restore
#line 27 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\Pages\ListOfUsers.razor"
                                user.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            , 11, (user) => (__builder2) => {
                __builder2.AddMarkupContent(12, "<div style=\"height: 50px;margin: 10px\"><div class=\"spinner-border spinner-dark\"></div></div>");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Arash\source\repos\Learning_Blazor_WebAssembly\Learning_Blazor_WebAssembly\Learning_Virtualize_component\client\Pages\ListOfUsers.razor"
      
    public List<ViewModels.User.UserViewModel> Users { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Users = new List<ViewModels.User.UserViewModel>();

        //Users = await userService.GetAllAsync();
    }  

    /*private async ValueTask<ItemsProviderResult<ViewModels.User.UserViewModel>> 
        LoadVisibleUsers(ItemsProviderRequest itemsProviderRequest)
    {
        Console.WriteLine($"start: {itemsProviderRequest.StartIndex}");
        Console.WriteLine( $"count: {itemsProviderRequest.Count}");

        return new ItemsProviderResult<ViewModels.User.UserViewModel>(new List<ViewModels.User.UserViewModel>(),20000);
    }*/

    /*private async ValueTask<ItemsProviderResult<ViewModels.User.UserViewModel>> 
        LoadVisibleUsers(ItemsProviderRequest itemsProviderRequest)
    {
        var result = 
            await userService.
            GetVisibleAsync(itemsProviderRequest.StartIndex , itemsProviderRequest.Count);
        
        
        return new ItemsProviderResult<ViewModels.User.UserViewModel>(result,20000);
    }*/

    private async ValueTask<ItemsProviderResult<ViewModels.User.UserViewModel>> 
        LoadVisibleUsers(ItemsProviderRequest itemsProviderRequest)
    {
        Task.Delay(500);

        var result = 
            await userService.
            GetVisibleAsync(itemsProviderRequest.StartIndex , itemsProviderRequest.Count);
        
        
        return new ItemsProviderResult<ViewModels.User.UserViewModel>(result,20000);
    }  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.UserService userService { get; set; }
    }
}
namespace __Blazor.Client.Pages.ListOfUsers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ItemsProvider", __arg0);
        __builder.AddAttribute(__seq1, "ItemContent", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
