#pragma checksum "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0218721e82a95ed8e89025825c3ea6fcad8ecfc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Bilet), @"mvc.1.0.view", @"/Views/Home/Bilet.cshtml")]
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
#line 1 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\_ViewImports.cshtml"
using OtobusBiletRezervasyon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\_ViewImports.cshtml"
using OtobusBileti.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0218721e82a95ed8e89025825c3ea6fcad8ecfc3", @"/Views/Home/Bilet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b05ec940da9f1c429e896b6b58894ce8eabc251", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Bilet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Yol>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Yolcu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h1>İSTENİLEN TARİHTE SEFER BULUNAMADI</h1>\r\n</center>\r\n");
#nullable restore
#line 10 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0218721e82a95ed8e89025825c3ea6fcad8ecfc34961", async() => {
                WriteLiteral("\r\n            <div class=\"w-100 \">\r\n                <div class=\"row\">\r\n                    <div class=\"col-3 border border-info \">\r\n                        <p class=\"fs-2 text-center\">NEREDEN</p>\r\n                        <p class=\"text-center fs-4\">");
#nullable restore
#line 19 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
                                               Write(item.Nereden);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <input type=\"hidden\" name=\"Nereden\"");
                BeginWriteAttribute("value", " value=\"", 562, "\"", 583, 1);
#nullable restore
#line 20 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
WriteAttributeValue("", 570, item.Nereden, 570, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-3 border border-info\">\r\n                        <p class=\"fs-2 text-center\">NEREYE</p>\r\n                        <p class=\"text-center fs-4\">");
#nullable restore
#line 24 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
                                               Write(item.Nereye);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <input type=\"hidden\" name=\"Nereye\"");
                BeginWriteAttribute("value", " value=\"", 869, "\"", 889, 1);
#nullable restore
#line 25 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
WriteAttributeValue("", 877, item.Nereye, 877, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-2 border border-info\">\r\n                        <p class=\"fs-2 text-center \">TARİH</p>\r\n                        <p class=\"text-center fs-4\">");
#nullable restore
#line 29 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
                                               Write(item.Tarih);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <input type=\"hidden\" name=\"Tarih\"");
                BeginWriteAttribute("value", " value=\"", 1173, "\"", 1192, 1);
#nullable restore
#line 30 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
WriteAttributeValue("", 1181, item.Tarih, 1181, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-2 border border-info\">\r\n                        <p class=\"fs-2 text-center \"> SEFER SAATİ</p>\r\n                        <p class=\"text-center fs-4\">");
#nullable restore
#line 34 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
                                               Write(item.Saat);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <input type=\"hidden\" name=\"Saat\"");
                BeginWriteAttribute("value", " value=\"", 1481, "\"", 1499, 1);
#nullable restore
#line 35 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
WriteAttributeValue("", 1489, item.Saat, 1489, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n\r\n                    </div>\r\n                    <div class=\"col-1 border border-info\">\r\n                        <p class=\"fs-2 text-center \">FİYAT</p>\r\n                        <p class=\"text-center fs-4\">");
#nullable restore
#line 42 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
                                               Write(item.Fiyat);

#line default
#line hidden
#nullable disable
                WriteLiteral(" TL</p>\r\n                        <input type=\"hidden\" name=\"Fiyat\"");
                BeginWriteAttribute("value", " value=\"", 1792, "\"", 1811, 1);
#nullable restore
#line 43 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
WriteAttributeValue("", 1800, item.Fiyat, 1800, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"YolId\"");
                BeginWriteAttribute("value", " value=\"", 1874, "\"", 1893, 1);
#nullable restore
#line 44 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
WriteAttributeValue("", 1882, item.YolId, 1882, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />


                    </div>
                    <div class=""col-1 border border-info d-flex justify-content-center align-items-center"">
                        <button type=""submit"" class=""btn btn-primary"">REZERVE</button>

                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\ARDA\Desktop\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Bilet.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Yol>> Html { get; private set; }
    }
}
#pragma warning restore 1591
