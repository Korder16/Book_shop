#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f917535a0db64648469744ce73c8da579520c26e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_AddClient), @"mvc.1.0.view", @"/Views/Client/AddClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/AddClient.cshtml", typeof(AspNetCore.Views_Client_AddClient))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f917535a0db64648469744ce73c8da579520c26e", @"/Views/Client/AddClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_AddClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_shop2.Models.client>
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
#line 3 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(93, 199, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #f5f5f5;\r\n    }\r\n    .form-signin {\r\n        width: 100%;\r\n        max-width: 330px;\r\n        padding: 15px;\r\n        margin: auto;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(292, 2644, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c7383b21ff4b788d240e9be7e31881", async() => {
                BeginContext(318, 52, true);
                WriteLiteral("\r\n<h1>Новый клиент</h1>\r\n<div class=\"form-signin\">\r\n");
                EndContext();
#line 21 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
     using (Html.BeginForm())
    {
        
        

#line default
#line hidden
                BeginContext(427, 28, false);
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
                                     
        
        
        // Имя клиента

#line default
#line hidden
                BeginContext(501, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(548, 49, false);
#line 29 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.LabelFor(model => model.Name, "Имя клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(597, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(612, 65, false);
#line 30 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.TextBoxFor(model => model.Name, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(677, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(692, 46, false);
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(738, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 33 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
        
        
        // Телефон клиента

#line default
#line hidden
                BeginContext(804, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(851, 54, false);
#line 37 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.LabelFor(model => model.Phone, "Телефон клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(905, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(920, 66, false);
#line 38 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.TextBoxFor(model => model.Phone, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(986, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1001, 47, false);
#line 39 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(1048, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 41 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
        
        
        // Электронная почта клиента

#line default
#line hidden
                BeginContext(1124, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1171, 64, false);
#line 45 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.LabelFor(model => model.Email, "Электронная почта клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(1235, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1250, 66, false);
#line 46 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.TextBoxFor(model => model.Email, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1316, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1331, 47, false);
#line 47 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1378, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 49 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
        
        
        // Адрес клиента

#line default
#line hidden
                BeginContext(1442, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1489, 53, false);
#line 53 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.LabelFor(model => model.Adress, "Адрес клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(1542, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1557, 67, false);
#line 54 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.TextBoxFor(model => model.Adress, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1624, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1639, 48, false);
#line 55 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
       Write(Html.ValidationMessageFor(model => model.Adress));

#line default
#line hidden
                EndContext();
                BeginContext(1687, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
                BeginContext(1725, 200, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-success btn-block\" value=\"Добавить клиента\"/>\r\n        </div>                                                       \r\n");
                EndContext();
#line 62 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Client\AddClient.cshtml"
    }

#line default
#line hidden
                BeginContext(1932, 10, true);
                WriteLiteral("</div>\r\n\r\n");
                EndContext();
                DefineSection("scripts", async() => {
                    BeginContext(1959, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                    BeginContext(1967, 234, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65009986b5b44b77b24a8ad2b515f085", async() => {
                        BeginContext(2000, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2010, 71, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cd09e8b33a241298a2336b8bb2a4cee", async() => {
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
                        BeginContext(2081, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2091, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b21a8aa4b7f45c0b0b0b8c3d0e041cb", async() => {
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
                        BeginContext(2181, 6, true);
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
                    BeginContext(2201, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(2207, 717, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e524d8256bb46769ddbd841906c33eb", async() => {
                        BeginContext(2247, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2257, 277, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce71181cb7d440c6ab629787f3f3216e", async() => {
                            BeginContext(2515, 10, true);
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
                        BeginContext(2534, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2544, 360, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "007e33a5526049439c15f72c54a35a1c", async() => {
                            BeginContext(2885, 10, true);
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
                        BeginContext(2904, 6, true);
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
                    BeginContext(2924, 2, true);
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
