#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb5c731857a5b05994fbb3db268cb5f889ee349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_CreateBook), @"mvc.1.0.view", @"/Views/Book/CreateBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/CreateBook.cshtml", typeof(AspNetCore.Views_Book_CreateBook))]
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
#line 1 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\_ViewImports.cshtml"
using Book_shop2;

#line default
#line hidden
#line 1 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
using Book_shop2.Models;

#line default
#line hidden
#line 2 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
using Microsoft.AspNetCore.Mvc.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb5c731857a5b05994fbb3db268cb5f889ee349", @"/Views/Book/CreateBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_CreateBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_shop2.Models.book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://ajax.aspnetcdn.com/ajax/jquery.validate/1.14.0/jquery.validate.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-src", "~/lib/jquery-validation/dist/jquery.validate.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test", "window.jQuery && window.jQuery.validator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-src", "~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test", "window.jQuery && window.jQuery.validator && window.jQuery.validator.unobtrusive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(159, 199, true);
            WriteLiteral("<style>\r\n    body {\r\n        background-color: #f5f5f5;\r\n    }\r\n    .form-signin {\r\n        width: 100%;\r\n        max-width: 330px;\r\n        padding: 15px;\r\n        margin: auto;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(358, 3162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e09f7eac09b42beac06fdd4cd554303", async() => {
                BeginContext(384, 51, true);
                WriteLiteral("\r\n<h1>Новая книга</h1>\r\n<div class=\"form-signin\">\r\n");
                EndContext();
#line 23 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
     using (Html.BeginForm())
    {
        
        

#line default
#line hidden
                BeginContext(492, 28, false);
#line 26 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
#line 26 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
                                     
        
        // Название книги

#line default
#line hidden
                BeginContext(559, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(606, 52, false);
#line 30 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.LabelFor(model => model.name, "Название книги"));

#line default
#line hidden
                EndContext();
                BeginContext(658, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(673, 65, false);
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.TextBoxFor(model => model.name, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(738, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(753, 46, false);
#line 32 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.ValidationMessageFor(model => model.name));

#line default
#line hidden
                EndContext();
                BeginContext(799, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 34 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
        
        
        // Автор книги

#line default
#line hidden
                BeginContext(861, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(908, 45, false);
#line 38 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.LabelFor(model => model.author, "Автор"));

#line default
#line hidden
                EndContext();
                BeginContext(953, 19, true);
                WriteLiteral("<br/>\r\n            ");
                EndContext();
                BeginContext(973, 67, false);
#line 39 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.TextBoxFor(model => model.author, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1040, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1055, 48, false);
#line 40 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.ValidationMessageFor(model => model.author));

#line default
#line hidden
                EndContext();
                BeginContext(1103, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 42 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
        
        
        // Жанр книги

#line default
#line hidden
                BeginContext(1164, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1211, 43, false);
#line 46 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.LabelFor(model => model.genre, "Жанр"));

#line default
#line hidden
                EndContext();
                BeginContext(1254, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1269, 66, false);
#line 47 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.TextBoxFor(model => model.genre, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1335, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1350, 47, false);
#line 48 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.ValidationMessageFor(model => model.genre));

#line default
#line hidden
                EndContext();
                BeginContext(1397, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 50 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
        
        
        // Цена книги

#line default
#line hidden
                BeginContext(1458, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1505, 43, false);
#line 54 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.LabelFor(model => model.price, "Цена"));

#line default
#line hidden
                EndContext();
                BeginContext(1548, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1563, 66, false);
#line 55 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.TextBoxFor(model => model.price, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1629, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1644, 47, false);
#line 56 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.ValidationMessageFor(model => model.price));

#line default
#line hidden
                EndContext();
                BeginContext(1691, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 58 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
        
        
        // Год издания

#line default
#line hidden
                BeginContext(1753, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1800, 41, false);
#line 62 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.LabelFor(model => model.year, "Год"));

#line default
#line hidden
                EndContext();
                BeginContext(1841, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1856, 65, false);
#line 63 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.TextBoxFor(model => model.year, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1921, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1936, 46, false);
#line 64 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.ValidationMessageFor(model => model.year));

#line default
#line hidden
                EndContext();
                BeginContext(1982, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 66 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
        
        
        // Количество

#line default
#line hidden
                BeginContext(2043, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2090, 49, false);
#line 70 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.LabelFor(model => model.count, "Количество"));

#line default
#line hidden
                EndContext();
                BeginContext(2139, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2154, 66, false);
#line 71 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.TextBoxFor(model => model.count, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(2220, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2235, 47, false);
#line 72 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
       Write(Html.ValidationMessageFor(model => model.count));

#line default
#line hidden
                EndContext();
                BeginContext(2282, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
                BeginContext(2310, 199, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-success btn-block\" value=\"Добавить книгу\"/>\r\n        </div>                                                        \r\n");
                EndContext();
#line 78 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Book\CreateBook.cshtml"
    }

#line default
#line hidden
                BeginContext(2516, 10, true);
                WriteLiteral("</div>\r\n\r\n");
                EndContext();
                DefineSection("scripts", async() => {
                    BeginContext(2543, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                    BeginContext(2551, 234, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72adcaa780e84f45addec87a61be61c1", async() => {
                        BeginContext(2584, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2594, 71, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a834cb16d4438a85835fcef12e0faa", async() => {
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2665, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2675, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d6b60032527491988d6924bcebc389d", async() => {
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2765, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2785, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(2791, 717, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db9deb7b97e4d2290064962d37762a4", async() => {
                        BeginContext(2831, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2841, 277, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b97d06539c940079fe4d9c1c62672a4", async() => {
                            BeginContext(3099, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackSrc = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackTestExpression = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(3118, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(3128, 360, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52f5287cae0c4649be16efc68fc684b2", async() => {
                            BeginContext(3469, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackSrc = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackTestExpression = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(3488, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3508, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_shop2.Models.book> Html { get; private set; }
    }
}
#pragma warning restore 1591
