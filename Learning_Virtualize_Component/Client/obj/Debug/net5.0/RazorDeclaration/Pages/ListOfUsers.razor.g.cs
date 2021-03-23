// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
