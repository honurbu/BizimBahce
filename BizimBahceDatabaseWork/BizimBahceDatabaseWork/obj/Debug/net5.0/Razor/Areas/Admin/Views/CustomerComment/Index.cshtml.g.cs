#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52869b8f0d693a17861556f1671be5bf815c3b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CustomerComment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CustomerComment/Index.cshtml")]
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
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
using BizimBahceDatabaseWork.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52869b8f0d693a17861556f1671be5bf815c3b4a", @"/Areas/Admin/Views/CustomerComment/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_CustomerComment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
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
#nullable restore
#line 4 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52869b8f0d693a17861556f1671be5bf815c3b4a3377", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Yorum Tablosu</h5>
                        <div class=""ibox-tools"">
                        </div>
                    </div>
                    <div class=""ibox-content"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>Yorum Sahibinin Adı-Soyadı</th>
                                    <th>Yorum Başlığı</th>
                                    <th>Yorum İçeriği</th>
                                    <th>Yorum Aktiflik Durumu</th>
                                    <th>Sil</th>
                                    <th>Aktif Yap</th>
                                </tr>
                            </thead>
                        ");
                WriteLiteral("    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 36 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                       Write(item.Customer.CustomerName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 36 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                                                   Write(item.Customer.CustomerSurname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 37 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                       Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 38 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                       Write(item.CommentSubject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 39 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                       Write(item.IsActive);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1729, "\"", 1788, 2);
                WriteAttributeValue("", 1736, "/Admin/CustomerComment/CommentDelete/", 1736, 37, true);
#nullable restore
#line 40 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
WriteAttributeValue("", 1773, item.CommentID, 1773, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1881, "\"", 1940, 2);
                WriteAttributeValue("", 1888, "/Admin/CustomerComment/CommentActive/", 1888, 37, true);
#nullable restore
#line 41 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
WriteAttributeValue("", 1925, item.CommentID, 1925, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-success\">Aktifleştir</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Admin\Views\CustomerComment\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
