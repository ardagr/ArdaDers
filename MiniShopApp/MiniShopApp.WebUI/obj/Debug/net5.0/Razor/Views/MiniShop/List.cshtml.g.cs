#pragma checksum "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ed8d954568e56a29ce81eb175a00866c3abaa64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MiniShop_List), @"mvc.1.0.view", @"/Views/MiniShop/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ed8d954568e56a29ce81eb175a00866c3abaa64", @"/Views/MiniShop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32df49b1e93c638c1b5fce74e8e1fde56f9e8fb7", @"/Views/_ViewImports.cshtml")]
    public class Views_MiniShop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NoProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 5 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
             if (Model.Products.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ed8d954568e56a29ce81eb175a00866c3abaa645518", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ed8d954568e56a29ce81eb175a00866c3abaa647246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = product;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 21 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav>\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 28 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                             if (string.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1082, "\"", 1150, 2);
            WriteAttributeValue("", 1090, "page-item", 1090, 9, true);
#nullable restore
#line 32 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue(" ", 1099, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1100, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1192, "\"", 1220, 2);
            WriteAttributeValue("", 1199, "/products?page=", 1199, 15, true);
#nullable restore
#line 33 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue("", 1214, i+1, 1214, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 33 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 35 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1422, "\"", 1490, 2);
            WriteAttributeValue("", 1430, "page-item", 1430, 9, true);
#nullable restore
#line 38 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue(" ", 1439, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1440, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1532, "\"", 1592, 4);
            WriteAttributeValue("", 1539, "/products/", 1539, 10, true);
#nullable restore
#line 39 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue("", 1549, Model.PageInfo.CurrentCategory, 1549, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1580, "?page=", 1580, 6, true);
#nullable restore
#line 39 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
WriteAttributeValue("", 1586, i+1, 1586, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 39 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                                                                                                                  Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 41 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ARDA\Desktop\Web_7_Projects\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\MiniShop\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
