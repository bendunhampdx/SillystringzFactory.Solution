#pragma checksum "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c2d95a0eb0ea51307d5254bc8e1da03438d73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Details), @"mvc.1.0.view", @"/Views/Engineers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c2d95a0eb0ea51307d5254bc8e1da03438d73f", @"/Views/Engineers/Details.cshtml")]
    public class Views_Engineers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"jumbotron\">\n  <h2>Engineer Details</h2>\n</div>\n<hr />\n<h3>");
#nullable restore
#line 11 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.DisplayNameFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>");
#nullable restore
#line 12 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
                                              Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 13 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This Engineer is not assigned to any machines.</p>\n");
#nullable restore
#line 16 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Machines the Engineer is assigned to:</h4>\n  <ul>\n");
#nullable restore
#line 21 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
     foreach(var join in Model.JoinEntities)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 23 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
     Write(join.Machine.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 24 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 26 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\n");
#nullable restore
#line 28 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
     using (Html.BeginForm("DeleteMachine", "Engineers"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
 Write(Html.Hidden("JoinId", @join.MachineEngineerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\n");
#nullable restore
#line 34 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 38 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.ActionLink("Add a Machine", "AddMachine", new { id = Model.EngineerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 39 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 40 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.ActionLink("Edit Engineer", "Edit", new { id = Model.EngineerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 41 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.ActionLink("Delete Engineer", "Delete", new { id = Model.EngineerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 42 "/Users/benjamindunham/Desktop/epicodus/week-11/SillyStringzFactory.Solution/Factory/Views/Engineers/Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
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
