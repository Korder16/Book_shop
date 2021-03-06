#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e48242393aaa4339b084876e2a472dedecbee2c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_Providers), @"mvc.1.0.view", @"/Views/Provider/Providers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Provider/Providers.cshtml", typeof(AspNetCore.Views_Provider_Providers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e48242393aaa4339b084876e2a472dedecbee2c6", @"/Views/Provider/Providers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_Providers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book_shop2.Models.provider>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(102, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(112, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45fa982f42648189a2b85ebb2eecf4b", async() => {
                BeginContext(118, 41, true);
                WriteLiteral("\r\n    <title>Список поставщиков</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(166, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(168, 635, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbdf831db0de4202a17e60619b8acbfc", async() => {
                BeginContext(174, 381, true);
                WriteLiteral(@"
<div>
    <h3>Поставщики</h3>
</div>
<div style=""position: fixed; top: 67px; right: 200px;"">
    <a href=""../Provider/CreateProvider"" type=""button"" class=""btn btn-success"">Добавить нового поставщика</a>
</div>
<table class=""table table-striped"">
    <tr>
        <td>Название</td>
        <td>Город</td>
        <td>Телефон</td>
        <td>Эл. почта</td>
    </tr>
");
                EndContext();
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
     foreach (var provider in Model)
    {

#line default
#line hidden
                BeginContext(600, 30, true);
                WriteLiteral("        <tr>\r\n            <td>");
                EndContext();
                BeginContext(631, 13, false);
#line 27 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
           Write(provider.Name);

#line default
#line hidden
                EndContext();
                BeginContext(644, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(668, 13, false);
#line 28 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
           Write(provider.City);

#line default
#line hidden
                EndContext();
                BeginContext(681, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(705, 14, false);
#line 29 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
           Write(provider.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(719, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(743, 14, false);
#line 30 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
           Write(provider.Email);

#line default
#line hidden
                EndContext();
                BeginContext(757, 22, true);
                WriteLiteral("</td>\r\n        </tr>\r\n");
                EndContext();
#line 32 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Provider\Providers.cshtml"
    }

#line default
#line hidden
                BeginContext(786, 10, true);
                WriteLiteral("</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(803, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book_shop2.Models.provider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
