#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c100e49f793dfbc08a5ab2d7beaac6989d51ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supply_AddSupply), @"mvc.1.0.view", @"/Views/Supply/AddSupply.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Supply/AddSupply.cshtml", typeof(AspNetCore.Views_Supply_AddSupply))]
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
#line 1 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
using Book_shop2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c100e49f793dfbc08a5ab2d7beaac6989d51ed", @"/Views/Supply/AddSupply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Supply_AddSupply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_shop2.ViewModels.SupplyModel>
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(128, 199, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #f5f5f5;\r\n    }\r\n    .form-signin {\r\n        width: 100%;\r\n        max-width: 330px;\r\n        padding: 15px;\r\n        margin: auto;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(327, 2756, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f5a7e93b20432788a61105afd7c6c3", async() => {
                BeginContext(353, 54, true);
                WriteLiteral("\r\n<h1>Новая поставка</h1>\r\n<div class=\"form-signin\">\r\n");
                EndContext();
#line 22 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
     using (Html.BeginForm())
    {
        
        

#line default
#line hidden
                BeginContext(464, 28, false);
#line 25 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
#line 25 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
                                     
        
        
        // Поставщик

#line default
#line hidden
                BeginContext(536, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(583, 54, false);
#line 30 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.LabelFor(model => model.Provider_id, "Поставщик"));

#line default
#line hidden
                EndContext();
                BeginContext(637, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(652, 145, false);
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.DropDownListFor(model => model.Provider_id, new SelectList(Model.Providers, "Value", "Text"), 
                new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(797, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(812, 53, false);
#line 33 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.ValidationMessageFor(model => model.Provider_id));

#line default
#line hidden
                EndContext();
                BeginContext(865, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 35 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
        
        
        // Название книги

#line default
#line hidden
                BeginContext(930, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(977, 55, false);
#line 39 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.LabelFor(model => model.Book_id, "Название книги"));

#line default
#line hidden
                EndContext();
                BeginContext(1032, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1047, 137, false);
#line 40 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.DropDownListFor(model => model.Book_id, new SelectList(Model.Books, "Value", "Text"), 
                new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1184, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1199, 49, false);
#line 42 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.ValidationMessageFor(model => model.Book_id));

#line default
#line hidden
                EndContext();
                BeginContext(1248, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 44 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
        
       
        // Цена книги

#line default
#line hidden
                BeginContext(1308, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1355, 43, false);
#line 48 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.LabelFor(model => model.Price, "Цена"));

#line default
#line hidden
                EndContext();
                BeginContext(1398, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1413, 66, false);
#line 49 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.TextBoxFor(model => model.Price, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1479, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1494, 47, false);
#line 50 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1541, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 52 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
        
        
        // Количество книг

#line default
#line hidden
                BeginContext(1607, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1654, 49, false);
#line 56 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.LabelFor(model => model.Count, "Количество"));

#line default
#line hidden
                EndContext();
                BeginContext(1703, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1718, 66, false);
#line 57 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.TextBoxFor(model => model.Count, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1784, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1799, 47, false);
#line 58 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
       Write(Html.ValidationMessageFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1846, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
                BeginContext(1884, 188, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-success btn-block\" value=\"Добавить поставку\"/>\r\n        </div>                                          \r\n");
                EndContext();
#line 65 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Supply\AddSupply.cshtml"
    }

#line default
#line hidden
                BeginContext(2079, 10, true);
                WriteLiteral("</div>\r\n\r\n");
                EndContext();
                DefineSection("scripts", async() => {
                    BeginContext(2106, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                    BeginContext(2114, 234, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc59bef499374e80a7c4ffe223e1ee91", async() => {
                        BeginContext(2147, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2157, 71, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5d4570b219943e6a5652edff324636e", async() => {
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
                        BeginContext(2228, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2238, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbaef61081e24ff4a3af7efd8164d69f", async() => {
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
                        BeginContext(2328, 6, true);
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
                    BeginContext(2348, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(2354, 717, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d94adcbceeb46c786cc914012cb9e36", async() => {
                        BeginContext(2394, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2404, 277, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b41eb2fb6834c449f5bd1b73e57ea2e", async() => {
                            BeginContext(2662, 10, true);
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
                        BeginContext(2681, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2691, 360, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d536296db8344f2ba02c7111ae367603", async() => {
                            BeginContext(3032, 10, true);
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
                        BeginContext(3051, 6, true);
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
                    BeginContext(3071, 2, true);
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
            BeginContext(3083, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_shop2.ViewModels.SupplyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
