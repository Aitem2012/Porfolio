#pragma checksum "C:\Users\hp\source\repos\TechArtProfileProject\TechArtProfileProject\Views\Home\Dummydashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e81846390332709e791ddd0fe8f5e552be894c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dummydashboard), @"mvc.1.0.view", @"/Views/Home/Dummydashboard.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\TechArtProfileProject\TechArtProfileProject\Views\_ViewImports.cshtml"
using TechArtProfileProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\TechArtProfileProject\TechArtProfileProject\Views\_ViewImports.cshtml"
using TechArtProfileProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\source\repos\TechArtProfileProject\TechArtProfileProject\Views\_ViewImports.cshtml"
using TechArtProfileProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e81846390332709e791ddd0fe8f5e552be894c", @"/Views/Home/Dummydashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298aecd1599cb292bc8bb60087011b372759e2a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dummydashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllUserProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\TechArtProfileProject\TechArtProfileProject\Views\Home\Dummydashboard.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""card"" style=""height: 200px"">
            <div class=""card-body"">
                <h2 style=""text-align:center"">Profile</h2>
                <div class=""text-center text-primary"" >
                    <i class=""fas fa-user fa-4x""></i>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllUserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
