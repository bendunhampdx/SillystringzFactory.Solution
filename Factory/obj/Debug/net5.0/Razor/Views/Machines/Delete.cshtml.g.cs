#pragma checksum "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c08a848d615e7d1fa6596276f0f2eaf9bc01b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Delete), @"mvc.1.0.view", @"/Views/Machines/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c08a848d615e7d1fa6596276f0f2eaf9bc01b6", @"/Views/Machines/Delete.cshtml")]
    public class Views_Machines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Are you sure you want to delete this machine?</h2>\n\n");
#nullable restore
#line 9 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.MachineName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.MachineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
#nullable restore
#line 13 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 15 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591
