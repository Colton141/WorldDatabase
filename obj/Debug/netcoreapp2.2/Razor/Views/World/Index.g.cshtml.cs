#pragma checksum "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a114c866a73aa7f1d1fc648e3ad33753b5ff608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(worlddata.Pages.World.Views_World_Index), @"mvc.1.0.view", @"/Views/World/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/World/Index.cshtml", typeof(worlddata.Pages.World.Views_World_Index))]
namespace worlddata.Pages.World
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Guest/Desktop/worlddata/Views/_ViewImports.cshtml"
using worlddata;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a114c866a73aa7f1d1fc648e3ad33753b5ff608", @"/Views/World/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911c0b7c5691a700dd09bacb407ebe0b0ea4f5ca", @"/Views/_ViewImports.cshtml")]
    public class Views_World_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
   foreach (var country in Model)
  {
    

#line default
#line hidden
#line 4 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
     if(@country.GetCapital()>0 && @country.GetLifeExpectancy() >0)
    {

#line default
#line hidden
            BeginContext(117, 13, true);
            WriteLiteral("       <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 130, "", 163, 2);
            WriteAttributeValue("", 136, "/country/", 136, 9, true);
#line 6 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
WriteAttributeValue("", 145, country.GetCode(), 145, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(163, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(165, 17, false);
#line 6 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                          Write(country.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(182, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(184, 17, false);
#line 6 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                                             Write(country.GetCode());

#line default
#line hidden
            EndContext();
            BeginContext(201, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(203, 19, false);
#line 6 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                                                                Write(country.GetRegion());

#line default
#line hidden
            EndContext();
            BeginContext(222, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(224, 20, false);
#line 6 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                                                                                     Write(country.GetCapital());

#line default
#line hidden
            EndContext();
            BeginContext(244, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(246, 27, false);
#line 6 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                                                                                                           Write(country.GetLifeExpectancy());

#line default
#line hidden
            EndContext();
            BeginContext(273, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
    }else{

#line default
#line hidden
            BeginContext(294, 12, true);
            WriteLiteral("      <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 306, "", 338, 2);
            WriteAttributeValue("", 312, "country/", 312, 8, true);
#line 8 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
WriteAttributeValue("", 320, country.GetCode(), 320, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(338, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(340, 17, false);
#line 8 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                        Write(country.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(357, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(359, 17, false);
#line 8 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                                           Write(country.GetCode());

#line default
#line hidden
            EndContext();
            BeginContext(376, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(378, 19, false);
#line 8 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
                                                                              Write(country.GetRegion());

#line default
#line hidden
            EndContext();
            BeginContext(397, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
    }

#line default
#line hidden
#line 9 "/Users/Guest/Desktop/worlddata/Views/World/Index.cshtml"
     
  }

#line default
#line hidden
            BeginContext(417, 6, true);
            WriteLiteral("</ul>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591