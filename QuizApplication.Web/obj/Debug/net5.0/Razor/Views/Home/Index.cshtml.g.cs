#pragma checksum "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e89127c2f1e2476e4a93aa77e53ae523a199b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e89127c2f1e2476e4a93aa77e53ae523a199b5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0a9841420a02575674c10a2c93d60f868bf0a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<AllQuizzesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchResults", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateQuiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Create Quiz"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteQuiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e89127c2f1e2476e4a93aa77e53ae523a199b57628", async() => {
                WriteLiteral(@"
    <div class=""input-group col-sm-7 mx-auto"">
        <input type=""text"" class=""form-control"" name=""searchTerm"" style=""background-color: transparent; border-radius: 1em; color:black;"" placeholder=""Search quizzes.."" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
        <button class=""btn btn-transparent"" type=""submit""><i class=""icon fas fa-search"" style=""color: white""></i></button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e89127c2f1e2476e4a93aa77e53ae523a199b59711", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $("".btnalertMessage"").click(function (element) {
            console.log(element);
            Swal.fire({
                title: 'Are you ready to start ?',
                input: 'checkbox',
                inputPlaceholder: 'I agree to start'
            }).then((result) => {
                if (result.isConfirmed) {
                    if (result.value) {
                        Swal.fire({ icon: 'success', text: 'You agree with rules' });
                        location.href = '/Quiz/StartQuiz/' + element.currentTarget.dataset.quizid
                    } else {
                        Swal.fire({ icon: 'error', text: ""Permission denied"" });
                    }
                } else {
                    console.log(`modal was dismissed by ${result.dismiss}`)
                }
            })
        });
    });
</script>


<div cla");
            WriteLiteral("ss=\"row mx-auto\">\r\n");
#nullable restore
#line 40 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mx-auto card-holder\">\r\n    <div class=\"quizCard text-center\" style=\"width: 20em;\">\r\n        <p>No quizzes yet.</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e89127c2f1e2476e4a93aa77e53ae523a199b512188", async() => {
                WriteLiteral("<i class=\"icon fas fa-plus-square fa-2x\" style=\"color: white\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div> ");
#nullable restore
#line 47 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
       }
else
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
 foreach (var quiz in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-3 mx-auto card-holder\">\r\n    <div class=\"flip-card\">\r\n        <div class=\"flip-card-inner\">\r\n            <div class=\"flip-card-front\">\r\n                <img class=\"equalImg\"");
            BeginWriteAttribute("src", " src=\"", 2369, "\"", 2392, 1);
#nullable restore
#line 56 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2375, quiz.QuizLogoUrl, 2375, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <h4>");
#nullable restore
#line 57 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
               Write(quiz.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                <h5>");
#nullable restore
#line 58 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
               Write(quiz.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                <p>");
#nullable restore
#line 59 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
              Write(quiz.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 60 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                 if (@quiz.QuizQuestions.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>No questions yet</p> ");
#nullable restore
#line 62 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                        }
else if (@quiz.QuizQuestions.Count == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 65 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
Write(quiz.QuizQuestions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" question</p> ");
#nullable restore
#line 65 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                                          }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 68 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
Write(quiz.QuizQuestions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" questions</p>");
#nullable restore
#line 68 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"flip-card-back\">\r\n                <div style=\"margin-top: 85px;\">\r\n                    <a style=\"padding: 10px;\" title=\"Start\"><i class=\"icon fas fa-play fa-2x btnalertMessage\" style=\"color: white\" data-quizid=\"");
#nullable restore
#line 72 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                                                                                                                                           Write(quiz.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></i></a>\r\n");
#nullable restore
#line 73 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e89127c2f1e2476e4a93aa77e53ae523a199b517849", async() => {
                WriteLiteral("<i class=\"icon fas fa-trash fa-2x\" style=\"color: white\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                                                                          WriteLiteral(quiz.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 75 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
                                                                                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
#nullable restore
#line 80 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    <nav>\r\n        ");
#nullable restore
#line 84 "E:\Work\ДОНОР\QuizApplication.Web\Views\Home\Index.cshtml"
   Write(Html.Partial("PagerOptions", this.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </nav>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<AllQuizzesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
