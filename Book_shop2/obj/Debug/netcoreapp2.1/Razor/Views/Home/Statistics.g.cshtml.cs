#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc3151fd228e0150579e883083150b577e12a2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Statistics), @"mvc.1.0.view", @"/Views/Home/Statistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Statistics.cshtml", typeof(AspNetCore.Views_Home_Statistics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc3151fd228e0150579e883083150b577e12a2d", @"/Views/Home/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(64, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6fc9945ad244bf89f317f5f3c982d1b", async() => {
                BeginContext(70, 33, true);
                WriteLiteral("\r\n    <title>Статистики</title>\r\n");
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
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(112, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb4f7558c8bc4fc18507f79c2cb665af", async() => {
                BeginContext(118, 296, true);
                WriteLiteral(@"
<div>
    <h3>Статистика по сотрудникам</h3>
</div>

<table class=""table table-striped"">
    <tr>
        <td>Имя</td>
        <td>Количество продаж</td>
        <td>Количество заказов</td>
        <td>Количество успешных</td>
        <td>Процент успешных заказов, %</td>
    </tr>
");
                EndContext();
#line 22 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
     foreach (var statistics in ViewBag.stuffStatistics)
    {

#line default
#line hidden
                BeginContext(479, 30, true);
                WriteLiteral("        <tr>\r\n            <td>");
                EndContext();
                BeginContext(510, 15, false);
#line 25 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
           Write(statistics.Name);

#line default
#line hidden
                EndContext();
                BeginContext(525, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(549, 25, false);
#line 26 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
           Write(statistics.PurchasesCount);

#line default
#line hidden
                EndContext();
                BeginContext(574, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(598, 22, false);
#line 27 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
           Write(statistics.OrdersCount);

#line default
#line hidden
                EndContext();
                BeginContext(620, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(644, 29, false);
#line 28 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
           Write(statistics.SuccessOrdersCount);

#line default
#line hidden
                EndContext();
                BeginContext(673, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(697, 24, false);
#line 29 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
           Write(statistics.OrdersPercent);

#line default
#line hidden
                EndContext();
                BeginContext(721, 22, true);
                WriteLiteral("</td>\r\n        </tr>\r\n");
                EndContext();
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Home\Statistics.cshtml"
    }

#line default
#line hidden
                BeginContext(750, 10, true);
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
            BeginContext(767, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
