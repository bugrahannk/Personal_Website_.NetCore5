#pragma checksum "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1f7959f9a04c8edb2e99bcb4113fcf3e435862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_EditExperience), @"mvc.1.0.view", @"/Views/Experience/EditExperience.cshtml")]
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
#line 1 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\_ViewImports.cshtml"
using Personal_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\_ViewImports.cshtml"
using Personal_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1f7959f9a04c8edb2e99bcb4113fcf3e435862", @"/Views/Experience/EditExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fabadb4d43d01059e8b452888e983487e1f5f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_EditExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
  
    ViewData["Title"] = "EditExperience";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n\r\n\r\n\r\n\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\"> Deneyim Güncelleme Sayfası</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
 using(Html.BeginForm("EditExperience", "Experience", FormMethod.Post)){
   

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
Write(Html.HiddenFor(x=> x.ExperienceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br />\r\n");
#nullable restore
#line 20 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
Write(Html.Label("Deneyim Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
Write(Html.TextBoxFor(x => x.Name, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Tarih Bilgisi</label>\r\n");
#nullable restore
#line 24 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
Write(Html.TextBoxFor(x => x.Date, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Resim Yolu</label>\r\n");
#nullable restore
#line 27 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Açıklama</label>\r\n");
#nullable restore
#line 30 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
Write(Html.TextAreaFor(x => x.Description,10,3, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-outline-success\">Güncelle</button>\r\n");
#nullable restore
#line 33 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Experience\EditExperience.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Experience> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591