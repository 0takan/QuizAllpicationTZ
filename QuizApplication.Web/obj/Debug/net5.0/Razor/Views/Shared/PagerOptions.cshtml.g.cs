#pragma checksum "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d21b353ff9eed0a68d230d2a3e67d80e5c86d52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PagerOptions), @"mvc.1.0.view", @"/Views/Shared/PagerOptions.cshtml")]
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
#line 1 "D:\QuizApplication\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\QuizApplication\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\QuizApplication\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\QuizApplication\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\QuizApplication\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Common.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d21b353ff9eed0a68d230d2a3e67d80e5c86d52", @"/Views/Shared/PagerOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600bdbc2afe17d97552f7b7bcb6697c5978d1f75", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PagerOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.IPagingList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
  
    var start = this.Model.StartPageIndex;
    var stop = this.Model.StopPageIndex;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    .icon:hover {\n        text-shadow: 0 0 5px #000;\n        transform: scale(1.5);\n    }   \n</style>\n");
#nullable restore
#line 14 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
 if (this.Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination pagination-lg justify-content-center\">\n\n\n");
#nullable restore
#line 19 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
         if (this.Model.PageIndex == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled card-holder\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 582, 1);
#nullable restore
#line 22 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 503, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex - 1)), 503, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\" class=\"page-link\" style=\"background-color: transparent\">\n                    <i class=\"icon fa fa-chevron-left\" style=\"color: white\" aria-hidden=\"true\"></i>\n                </a>\n            </li>\n");
#nullable restore
#line 26 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item card-holder\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 900, "\"", 986, 1);
#nullable restore
#line 30 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 907, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex - 1)), 907, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\" class=\"page-link\" style=\"background-color: transparent\">\n                    <i class=\"icon fa fa-chevron-left\" style=\"color: white\" aria-hidden=\"true\"></i>\n                </a>\n            </li>\n");
#nullable restore
#line 34 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 36 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
         if (this.Model.PageIndex == this.Model.PageCount)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled card-holder\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 1361, "\"", 1447, 1);
#nullable restore
#line 40 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 1368, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex + 1)), 1368, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\" style=\"background-color: transparent;\">\n                    <i class=\"icon fa fa-chevron-right\" style=\"color: white\" aria-hidden=\"true\"></i>\n                </a>\n            </li>\n");
#nullable restore
#line 44 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item card-holder\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 1763, "\"", 1849, 1);
#nullable restore
#line 48 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 1770, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex + 1)), 1770, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\" style=\"background-color: transparent\">\n                    <i class=\"icon fa fa-chevron-right\" style=\"color: white\" aria-hidden=\"true\"></i>\n                </a>\n            </li>\n");
#nullable restore
#line 52 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 54 "D:\QuizApplication\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.IPagingList> Html { get; private set; }
    }
}
#pragma warning restore 1591
