#pragma checksum "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0f5cafb544838ab7d967e06575122f2aa4dc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_EditSkill), @"mvc.1.0.view", @"/Views/Skill/EditSkill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0f5cafb544838ab7d967e06575122f2aa4dc28", @"/Views/Skill/EditSkill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fabadb4d43d01059e8b452888e983487e1f5f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_EditSkill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Skill>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
  
    ViewData["Title"] = "EditSkill";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\"> Yetenek G??ncelleme Sayfas??</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
 using(Html.BeginForm("EditSkill", "Skill", FormMethod.Post)){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
Write(Html.HiddenFor(x=>x.SkillId));

#line default
#line hidden
#nullable disable
            WriteLiteral("     <br />\r\n");
#nullable restore
#line 14 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
Write(Html.Label("Yetenek Ba??l??????"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
Write(Html.TextBoxFor(x => x.Title, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>De??er</label>\r\n");
#nullable restore
#line 18 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
Write(Html.TextBoxFor(x => x.Value, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">G??ncelle</button>\r\n");
#nullable restore
#line 21 "C:\Users\User.BUGRAHANPC\Desktop\setupStokApp\Personal_Website\Personal_Website\Views\Skill\EditSkill.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Skill> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
