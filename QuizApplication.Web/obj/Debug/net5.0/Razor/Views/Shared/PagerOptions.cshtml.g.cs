#pragma checksum "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5431ae2bec04cde02052fcafe54bb40c43795129"
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
#line 1 "E:\Work\ДОНОР\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Work\ДОНОР\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Work\ДОНОР\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Work\ДОНОР\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Work\ДОНОР\QuizApplication.Web\Views\_ViewImports.cshtml"
using QuizApplication.Common.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5431ae2bec04cde02052fcafe54bb40c43795129", @"/Views/Shared/PagerOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0a9841420a02575674c10a2c93d60f868bf0a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PagerOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.IPagingList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
  
    var start = this.Model.StartPageIndex;
    var stop = this.Model.StopPageIndex;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .icon:hover {\r\n        text-shadow: 0 0 5px #000;\r\n        transform: scale(1.5);\r\n    }   \r\n</style>\r\n");
#nullable restore
#line 14 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
 if (this.Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination pagination-lg justify-content-center\">\r\n\r\n\r\n");
#nullable restore
#line 19 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
         if (this.Model.PageIndex == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled card-holder\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 517, "\"", 603, 1);
#nullable restore
#line 22 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 524, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex - 1)), 524, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\" class=\"page-link\" style=\"background-color: transparent\">\r\n                    <i class=\"icon fa fa-chevron-left\" style=\"color: white\" aria-hidden=\"true\"></i>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 26 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item card-holder\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 929, "\"", 1015, 1);
#nullable restore
#line 30 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 936, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex - 1)), 936, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\" class=\"page-link\" style=\"background-color: transparent\">\r\n                    <i class=\"icon fa fa-chevron-left\" style=\"color: white\" aria-hidden=\"true\"></i>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 34 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
         if (this.Model.PageIndex == this.Model.PageCount)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled card-holder\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1400, "\"", 1486, 1);
#nullable restore
#line 40 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 1407, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex + 1)), 1407, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\" style=\"background-color: transparent;\">\r\n                    <i class=\"icon fa fa-chevron-right\" style=\"color: white\" aria-hidden=\"true\"></i>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 44 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item card-holder\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1810, "\"", 1896, 1);
#nullable restore
#line 48 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
WriteAttributeValue("", 1817, Url.Action(Model.Action, Model.GetRouteValueForPage(this.Model.PageIndex + 1)), 1817, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\" class=\"page-link\" style=\"background-color: transparent\">\r\n                    <i class=\"icon fa fa-chevron-right\" style=\"color: white\" aria-hidden=\"true\"></i>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 52 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 54 "E:\Work\ДОНОР\QuizApplication.Web\Views\Shared\PagerOptions.cshtml"
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
