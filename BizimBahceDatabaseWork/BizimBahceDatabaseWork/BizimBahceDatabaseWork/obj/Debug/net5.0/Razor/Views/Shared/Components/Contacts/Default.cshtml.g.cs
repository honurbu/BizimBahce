#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c918b8b9a63d5ba2ef968363245d9bb9e87c6db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Contacts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Contacts/Default.cshtml")]
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
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml"
using BizimBahceDatabaseWork.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c918b8b9a63d5ba2ef968363245d9bb9e87c6db", @"/Views/Shared/Components/Contacts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25e6a1d05f664826b9a3f577914debf4106ef84", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Contacts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section-title\">\r\n    <h4 class=\"text-primary text-uppercase\" style=\"letter-spacing: 5px;\">Bizimle İletişime Geçin</h4>\r\n    <h1 class=\"display-4\">İletişim Adreslerimiz</h1>\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row px-3 pb-2\">\r\n        <div class=\"col-sm-4 text-center mb-3\">\r\n            <i class=\"fa fa-2x fa-map-marker-alt mb-3 text-primary\"></i>\r\n            <h4 class=\"font-weight-bold\">Adres</h4>\r\n            <p>");
#nullable restore
#line 14 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml"
          Write(item.ContactAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-sm-4 text-center mb-3\">\r\n            <i class=\"fa fa-2x fa-phone-alt mb-3 text-primary\"></i>\r\n            <h4 class=\"font-weight-bold\">Telefon</h4>\r\n            <p>");
#nullable restore
#line 19 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml"
          Write(item.ContactPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-sm-4 text-center mb-3\">\r\n            <i class=\"far fa-2x fa-envelope mb-3 text-primary\"></i>\r\n            <h4 class=\"font-weight-bold\">Email</h4>\r\n            <p>");
#nullable restore
#line 24 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml"
          Write(item.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\Onur\Desktop\Windows Form Projelerim\BizimBahceDatabaseWork\BizimBahceDatabaseWork\Views\Shared\Components\Contacts\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 pb-5"">
        <iframe style=""width: 100%; height: 443px;""
                src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d716.2850407976517!2d29.978627032909895!3d39.427936033145066!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14c948741ede3bdf%3A0xdd84d3d81dca9dc2!2sMeydan%2C%20%C3%96mer%20Bedrettin%20Sk.%20No%3A2%2C%2043030%20K%C3%BCtahya%20Merkez%2FK%C3%BCtahya!5e1!3m2!1sen!2str!4v1668337272327!5m2!1sen!2str%22%20width=%22600%22%20height=%22450%22%20style=%22border:0;%22%20allowfullscreen=%22%22%20loading=%22lazy%22%20referrerpolicy=%22no-referrer-when-downgrade""
                frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1725, "\"", 1743, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"false\" tabindex=\"0\"></iframe>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
