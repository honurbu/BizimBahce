#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377bc0b58c48e3bcfe696d93992be556738ada04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminss_Views_AdminProduct_ManageOils), @"mvc.1.0.view", @"/Areas/Adminss/Views/AdminProduct/ManageOils.cshtml")]
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
#line 2 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
using BizimBahceDatabaseWork.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377bc0b58c48e3bcfe696d93992be556738ada04", @"/Areas/Adminss/Views/AdminProduct/ManageOils.cshtml")]
    #nullable restore
    public class Areas_Adminss_Views_AdminProduct_ManageOils : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OliveOil>>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
  
    ViewData["Title"] = "ManageOils";
    Layout = "~/Areas/Adminss/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ürün Yönetimi</h1>\r\n\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377bc0b58c48e3bcfe696d93992be556738ada043482", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Ürün Tablosu</h5>
                        <div class=""ibox-tools"">
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>Ürün ID</th>
                                    <th>Ürün Türü</th>
                                    <th>Ürün Açıklaması</th>
                                    <th>Ürün Fiyatı</th>
                                    <th>Sil</th>
                                    <th>Düzenle</th>

                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 39 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 42 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
                                       Write(item.OliveOilsID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
                                       Write(item.OliveOilType.OliveOilDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 44 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
                                       Write(item.OliveOilProperty.OliveOilDescription.Substring(0, item.OliveOilProperty.OliveOilDescription.Substring(0, 10).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
                WriteLiteral("...</td>\r\n");
                WriteLiteral("                                        <td>");
#nullable restore
#line 46 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
                                       Write(item.OliveOilPrice.OliveOilPriceLiter);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1952, "\"", 2012, 2);
                WriteAttributeValue("", 1959, "/Adminss/AdminProduct/ProductDelete/", 1959, 36, true);
#nullable restore
#line 47 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
WriteAttributeValue("", 1995, item.OliveOilsID, 1995, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 2105, "\"", 2165, 2);
                WriteAttributeValue("", 2112, "/Adminss/AdminProduct/UpdateProduct/", 2112, 36, true);
#nullable restore
#line 48 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
WriteAttributeValue("", 2148, item.OliveOilsID, 2148, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\ManageOils.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <a href=""/Adminss/AdminProduct/AddProduct"" class=""btn btn-primary"">Yeni Ürün Ekle</a>


            <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
            <script>
                $(""div.main-panel div.content-wrapper"").css(""overflow-x"", ""auto"");
            </script>
        ");
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
            WriteLiteral("\r\n        </html>\r\n\r\n");
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