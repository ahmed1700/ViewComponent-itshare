#pragma checksum "C:\Users\ITShare\source\repos\ViewComponentSys\ViewComponentSys\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf6513cc3093927d7aee9df6d6679b3de98676b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ViewComponent.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Details.cshtml", typeof(ViewComponent.Pages.Pages_Details), @"{id?}")]
namespace ViewComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ITShare\source\repos\ViewComponentSys\ViewComponentSys\Pages\_ViewImports.cshtml"
using ViewComponent;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6513cc3093927d7aee9df6d6679b3de98676b6", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"188bff69ebfb01d52de282ff1155e942936cc34d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(71, 93, false);
#line 7 "C:\Users\ITShare\source\repos\ViewComponentSys\ViewComponentSys\Pages\Details.cshtml"
Write(await Component.InvokeAsync("User", int.Parse(ViewContext.RouteData.Values["id"].ToString())));

#line default
#line hidden
            EndContext();
            BeginContext(164, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewComponentSys.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViewComponentSys.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ViewComponentSys.Pages.DetailsModel>)PageContext?.ViewData;
        public ViewComponentSys.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
