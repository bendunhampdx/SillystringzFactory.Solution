#pragma checksum "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99055886ff8c1453e3dd0980ccab1fea19bffb50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Edit), @"mvc.1.0.view", @"/Views/Engineers/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99055886ff8c1453e3dd0980ccab1fea19bffb50", @"/Views/Engineers/Edit.cshtml")]
    public class Views_Engineers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"jumbotron\">\n  <h2>Edit Engineer Info</h2>\n\n</div>\n\n<h4>Edit this Engineer: ");
#nullable restore
#line 12 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
                   Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 14 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>");
#nullable restore
#line 18 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.LabelFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <p>");
#nullable restore
#line 19 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.EditorFor(model =>model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("  <p>");
#nullable restore
#line 21 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.LabelFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <p>");
#nullable restore
#line 22 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.EditorFor(model =>model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("  <p>");
#nullable restore
#line 24 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.Label("Select Machine"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <p>");
#nullable restore
#line 25 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
            WriteLiteral("  <input type=\"submit\" value=\"Save\">\n");
#nullable restore
#line 28 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 30 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Edit.cshtml"
Write(Html.ActionLink("Back to Engineers", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
