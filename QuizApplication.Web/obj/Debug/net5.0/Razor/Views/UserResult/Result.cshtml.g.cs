#pragma checksum "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ebcebdf980428e86bc0d86fe07b69feb936588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserResult_Result), @"mvc.1.0.view", @"/Views/UserResult/Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ebcebdf980428e86bc0d86fe07b69feb936588", @"/Views/UserResult/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0a9841420a02575674c10a2c93d60f868bf0a7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserResult_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""mx-auto"">
        <div class=""mx-auto card-holder"">
            <div class=""quizCard text-left"" style=""width: 20em;"">
                <p class=""text-center"">Result</p>
                <p><i class=""icon fas fas fa-user fa-1x"" style=""color: white; margin-right:20px;""></i>  ");
#nullable restore
#line 12 "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml"
                                                                                                   Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><i class=\"icon fas fas fa-puzzle-piece fa-1x\" style=\"color: white; margin-right:20px; \"></i> ");
#nullable restore
#line 13 "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml"
                                                                                                           Write(Model.Quiz.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Quiz</p>\r\n                <p><i class=\"icon fas fas fa-check-circle fa-1x\" style=\"color: white; margin-right:20px;\"></i> ");
#nullable restore
#line 14 "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml"
                                                                                                          Write(Model.UsersCorrectAnswers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Correct</p>\r\n                <p><i class=\"icon fas fas fa-times-circle fa-1x\" style=\"color: white; margin-right:20px;\"></i> ");
#nullable restore
#line 15 "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml"
                                                                                                          Write(Model.UsersWrongAnswers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Wrong</p>\r\n                <p><i class=\"icon fas fas fa-check-double fa-1x\" style=\"color: white; margin-right:20px;\"></i> ");
#nullable restore
#line 16 "E:\Work\ДОНОР\QuizApplication.Web\Views\UserResult\Result.cshtml"
                                                                                                          Write(Model.PointsEarned);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Points earned</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
