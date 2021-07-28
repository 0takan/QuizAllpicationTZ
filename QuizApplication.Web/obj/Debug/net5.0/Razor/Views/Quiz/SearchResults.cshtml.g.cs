#pragma checksum "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a986176ba370969401db3ba004e8231a990830be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_SearchResults), @"mvc.1.0.view", @"/Views/Quiz/SearchResults.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a986176ba370969401db3ba004e8231a990830be", @"/Views/Quiz/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600bdbc2afe17d97552f7b7bcb6697c5978d1f75", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchResultsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StartQuiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Start"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\n<h1 style=\"font-size: 2.5em; font-weight: 800;\">\n    <i class=\"icon fa fa-search\" style=\"color: white;\" aria-hidden=\"true\">\n    </i> Results with <em style=\"color: red\">");
#nullable restore
#line 5 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                                        Write(Model.SearchTerm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>:\n</h1>\n\n");
#nullable restore
#line 8 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
 foreach (var quiz in Model.Quizzes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n        <div class=\"col align-self-center card-holder\">\n            <div class=\"serachResultBox bg-style\">\n                <div class=\"d-flex\">\n                    <div class=\"p-2\">\n                        <img class=\"equalImg\"");
            BeginWriteAttribute("src", " src=\"", 531, "\"", 554, 1);
#nullable restore
#line 15 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
WriteAttributeValue("", 537, quiz.QuizLogoUrl, 537, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No Image\" width=\"200\">\n                    </div>\n                    <div class=\"ml-auto p-2\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a986176ba370969401db3ba004e8231a990830be6363", async() => {
                WriteLiteral("<i class=\"icon fas fa-play fa-2x\" style=\"color: white\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                                                                                                 WriteLiteral(quiz.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 22 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                                      Write(quiz.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Quiz</h5>\n");
#nullable restore
#line 23 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                     if (@quiz.QuizQuestions.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>This quiz has no questions.</p>\n");
#nullable restore
#line 26 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                    }
                    else if (@quiz.QuizQuestions.Count == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>The quiz contains ");
#nullable restore
#line 29 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                                        Write(quiz.QuizQuestions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" question.</p>\n");
#nullable restore
#line 30 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>The quiz contains ");
#nullable restore
#line 33 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                                        Write(quiz.QuizQuestions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" questions.</p>\n");
#nullable restore
#line 34 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 39 "D:\QuizApplication\QuizApplication.Web\Views\Quiz\SearchResults.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchResultsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
