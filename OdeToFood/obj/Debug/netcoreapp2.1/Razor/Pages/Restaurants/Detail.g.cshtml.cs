#pragma checksum "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb95f22f14e6795c2c602c37a9adcb11b89df337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Detail), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Detail.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Detail), @"{restaurantId:int}")]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb95f22f14e6795c2c602c37a9adcb11b89df337", @"/Pages/Restaurants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd7a9498867045fbda097e3208cbd1c6a5a509f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(118, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(125, 21, false);
#line 7 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
Write(Model.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(146, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
 if (Model.Message != null)
{

#line default
#line hidden
            BeginContext(189, 34, true);
            WriteLiteral("    <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(224, 13, false);
#line 12 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
                             Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(237, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 13 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(248, 17, true);
            WriteLiteral("\r\n<div>\r\n    Id: ");
            EndContext();
            BeginContext(266, 19, false);
#line 16 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
   Write(Model.Restaurant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(285, 33, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(319, 25, false);
#line 20 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
         Write(Model.Restaurant.location);

#line default
#line hidden
            EndContext();
            BeginContext(344, 32, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    Cuisine: ");
            EndContext();
            BeginContext(377, 24, false);
#line 24 "C:\GitRepositories\pluralsight\OdeToFoodRepository\OdeToFood\Pages\Restaurants\Detail.cshtml"
        Write(Model.Restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(401, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(415, 64, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2518b8680574e2b8ce318312cfa0508", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0904d7a9fc9144eba00b2f5042bd7d05", async() => {
>>>>>>> 6128d5f56fe45039babc1e0ae9b42dc825a606f4
                BeginContext(460, 15, true);
                WriteLiteral("All Restaurants");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(479, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
