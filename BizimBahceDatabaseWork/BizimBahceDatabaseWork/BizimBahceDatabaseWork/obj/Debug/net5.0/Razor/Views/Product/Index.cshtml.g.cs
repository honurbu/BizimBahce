#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69351447688d67e9ebad798a2ed3f6b647eaf688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\_ViewImports.cshtml"
using BizimBahceDatabaseWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\_ViewImports.cshtml"
using BizimBahceDatabaseWork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
using BizimBahceDatabaseWork.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69351447688d67e9ebad798a2ed3f6b647eaf688", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25e6a1d05f664826b9a3f577914debf4106ef84", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OliveOil>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/img/dene4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_OliveLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69351447688d67e9ebad798a2ed3f6b647eaf6885444", async() => {
                WriteLiteral(@"
    <!-- Navbar Start -->
    <!-- Navbar End -->
    <!-- Page Header Start -->
    <div class=""container-fluid page-header mb-5 position-relative overlay-bottom"">
        <div class=""d-flex flex-column align-items-center justify-content-center pt-0 pt-lg-5"" style=""min-height: 400px"">
            <h1 class=""display-4 mb-3 mt-0 mt-lg-5 text-white text-uppercase"">Ürünlerimiz</h1>
            <div class=""d-inline-flex mb-lg-5"">
                <p class=""m-0 text-white""><a class=""text-white""");
                BeginWriteAttribute("href", " href=\"", 712, "\"", 719, 0);
                EndWriteAttribute();
                WriteLiteral(@">Home</a></p>
                <p class=""m-0 text-white px-2"">/</p>
                <p class=""m-0 text-white"">Menu</p>
            </div>
        </div>
    </div>
    <!-- Page Header End -->
    <!-- Menu Start -->
    <div class=""container-fluid pt-5"">
        <div class=""container"">
            <div class=""section-title"">
                <h4 class=""text-primary text-uppercase"" style=""letter-spacing: 5px;"">Ürünlerimiz & Fiyatlandırmalarımız</h4>
                <h1 class=""display-4"">Bütçe Dostu Fiyatlandırma</h1>
            </div>

            <div class=""row"">
                <div class=""col-lg-12"">
                    <h1 class=""mb-5 text-center"">Yağlarımız</h1>
                    <div class=""row d-flex justify-content-center align-items-start align-content-stretch mb-5"">
");
#nullable restore
#line 39 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-12 col-xl-6 col-md-8 mb-3 px-5 d-flex flex-column justify-content-start align-items-center\">\r\n                                <h4 class=\"text-center\">");
#nullable restore
#line 42 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
                                                   Write(item.OliveOilType.OliveOilDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69351447688d67e9ebad798a2ed3f6b647eaf6888091", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <h5 class=\"display bg-primary p-3 d-inline-block border rounded-lg text-white\">");
#nullable restore
#line 44 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
                                                                                                          Write(item.OliveOilPrice.OliveOilPriceLiter);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</h5>\r\n");
                WriteLiteral("                                <p class=\"m-0 text-justify\">");
#nullable restore
#line 46 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
                                                       Write(item.OliveOilProperty.OliveOilDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <br />\r\n                            </div>\r\n");
#nullable restore
#line 49 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Product\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <a href=\"#\" class=\"btn btn-lg btn-primary btn-lg-square back-to-top\"><i class=\"fa fa-angle-double-up\"></i></a>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OliveOil>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591