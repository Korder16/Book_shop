#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe905213379ff2873fcd3c382901868554556148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_EditClient), @"mvc.1.0.view", @"/Views/Client/EditClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/EditClient.cshtml", typeof(AspNetCore.Views_Client_EditClient))]
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
#line 2 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\_ViewImports.cshtml"
using Book_shop2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe905213379ff2873fcd3c382901868554556148", @"/Views/Client/EditClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_EditClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_shop2.Models.client>
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(93, 199, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #f5f5f5;\r\n    }\r\n    .form-signin {\r\n        width: 100%;\r\n        max-width: 330px;\r\n        padding: 15px;\r\n        margin: auto;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(292, 2664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c3123ed45194e748bb970aa4c6acf91", async() => {
                BeginContext(318, 75, true);
                WriteLiteral("\r\n<h1>Редактирование информации о клиенте</h1>\r\n<div class=\"form-signin\">\r\n");
                EndContext();
#line 21 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
     using (Html.BeginForm())
    {
        
        

#line default
#line hidden
                BeginContext(450, 28, false);
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
                                     
        
        
        // Имя клиента

#line default
#line hidden
                BeginContext(524, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(571, 49, false);
#line 29 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.LabelFor(model => model.Name, "Имя клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(620, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(635, 65, false);
#line 30 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.TextBoxFor(model => model.Name, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(700, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(715, 46, false);
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(761, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 33 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
        
        
        // Телефон клиента

#line default
#line hidden
                BeginContext(827, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(874, 54, false);
#line 37 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.LabelFor(model => model.Phone, "Телефон клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(928, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(943, 66, false);
#line 38 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.TextBoxFor(model => model.Phone, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1009, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1024, 47, false);
#line 39 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(1071, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 41 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
        
        
        // Электронная почта клиента

#line default
#line hidden
                BeginContext(1147, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1194, 64, false);
#line 45 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.LabelFor(model => model.Email, "Электронная почта клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(1258, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1273, 66, false);
#line 46 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.TextBoxFor(model => model.Email, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1339, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1354, 47, false);
#line 47 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1401, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 49 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
        
        
        // Адрес клиента

#line default
#line hidden
                BeginContext(1465, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1512, 53, false);
#line 53 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.LabelFor(model => model.Adress, "Адрес клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(1565, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1580, 67, false);
#line 54 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.TextBoxFor(model => model.Adress, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1647, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1662, 48, false);
#line 55 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Adress));

#line default
#line hidden
                EndContext();
                BeginContext(1710, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
                BeginContext(1748, 197, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-success btn-block\" value=\"Редактировать\"/>\r\n        </div>                                                       \r\n");
                EndContext();
#line 62 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\EditClient.cshtml"
    }

#line default
#line hidden
                BeginContext(1952, 10, true);
                WriteLiteral("</div>\r\n\r\n");
                EndContext();
                DefineSection("scripts", async() => {
                    BeginContext(1979, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                    BeginContext(1987, 234, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6392b5ee6cb4fe394e22be13a0610b3", async() => {
                        BeginContext(2020, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2030, 71, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bcbcb9e1d844820bf538d5da30c2bbc", async() => {
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
                        BeginContext(2101, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2111, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "337e15dcb0e54828aa9401a8a7e18ad8", async() => {
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
                        BeginContext(2201, 6, true);
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
                    BeginContext(2221, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(2227, 717, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6b7c94e6a2a4323ba601cd0685e25b2", async() => {
                        BeginContext(2267, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2277, 277, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee50bda6825541dcbe66f3915485900c", async() => {
                            BeginContext(2535, 10, true);
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
                        BeginContext(2554, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2564, 360, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ace4f4c877644ad8aa648370484fd975", async() => {
                            BeginContext(2905, 10, true);
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
                        BeginContext(2924, 6, true);
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
                    BeginContext(2944, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_shop2.Models.client> Html { get; private set; }
    }
}
#pragma warning restore 1591
