#pragma checksum "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c38af79339e8040fb9f62e6f5d664008e4b8202c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rezerve), @"mvc.1.0.view", @"/Views/Home/Rezerve.cshtml")]
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
#line 1 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\_ViewImports.cshtml"
using OtobusBiletRezervasyon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\_ViewImports.cshtml"
using OtobusBileti.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c38af79339e8040fb9f62e6f5d664008e4b8202c", @"/Views/Home/Rezerve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b05ec940da9f1c429e896b6b58894ce8eabc251", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rezerve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Yolcu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height: 350px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Resimler/rezervasyon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container col-m d-12 position-relative\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c38af79339e8040fb9f62e6f5d664008e4b8202c4335", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <p style=\"position: absolute; left: 75%; top: 50px; color: white; text-align: center;\">");
#nullable restore
#line 5 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                                          Write(Model.Nereden);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                                                           Write(Model.Nereye);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"position: absolute; left: 75%; top: 110px; color: white; \">");
#nullable restore
#line 6 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                        Write(Model.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"position: absolute; left: 75%; top: 180px; color: white; \">");
#nullable restore
#line 7 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                        Write(Model.KoltukNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"position: absolute; left: 75%; top: 245px; color: white; \">");
#nullable restore
#line 8 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                        Write(Model.Ad.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                                            Write(Model.Soyad.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"position: absolute; left: 75%; top: 310px; color: white;  \">");
#nullable restore
#line 9 "C:\Users\ARDA\Desktop\GİTHUPP\Otobüs\OtobusBiletRezervasyon\OtobusBiletRezervasyon\Views\Home\Rezerve.cshtml"
                                                                         Write(Model.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Yolcu> Html { get; private set; }
    }
}
#pragma warning restore 1591
