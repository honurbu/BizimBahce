#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a08d39ae01a30b40fe80226b09174896757f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminss_Views_AdminProduct_AddProduct), @"mvc.1.0.view", @"/Areas/Adminss/Views/AdminProduct/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a08d39ae01a30b40fe80226b09174896757f78", @"/Areas/Adminss/Views/AdminProduct/AddProduct.cshtml")]
    #nullable restore
    public class Areas_Adminss_Views_AdminProduct_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BizimBahceDatabaseWork.Models.Entities.OliveOil>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Areas/Adminss/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
 using (Html.BeginForm("AddProduct", "AdminProduct", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.Label("Yağ Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.OliveOilType.OliveOilDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.OliveOilType.OliveOilDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.Label("Ürün Fiyatı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.OliveOilPrice.OliveOilPriceLiter, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.OliveOilPrice.OliveOilPriceLiter, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.Label("Ürün Fayda"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.OliveOilBenefit.OliveOilBenefitDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.OliveOilBenefit.OliveOilBenefitDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 27 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.Label("Ürün Asit Özelliği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.OliveOilProperty.OliveOilAsidic, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.OliveOilProperty.OliveOilAsidic, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 32 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.Label("Ürün Litre"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.OliveOilProperty.OliveOilLiter, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.OliveOilProperty.OliveOilLiter, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 37 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.Label("Ürün Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.TextAreaFor(x => x.OliveOilProperty.OliveOilDescription, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"
Write(Html.ValidationMessageFor(x => x.OliveOilProperty.OliveOilDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\" id=\"btn1\">Ürünü Kaydet</button>\r\n");
#nullable restore
#line 47 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Areas\Adminss\Views\AdminProduct\AddProduct.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BizimBahceDatabaseWork.Models.Entities.OliveOil> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
