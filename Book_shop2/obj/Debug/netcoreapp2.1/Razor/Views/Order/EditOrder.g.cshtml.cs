#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a835077963b0cc261f8097ca0a3d222ac8e9eb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_EditOrder), @"mvc.1.0.view", @"/Views/Order/EditOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/EditOrder.cshtml", typeof(AspNetCore.Views_Order_EditOrder))]
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
#line 1 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
using Book_shop2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a835077963b0cc261f8097ca0a3d222ac8e9eb0", @"/Views/Order/EditOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_EditOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_shop2.ViewModels.EditOrderModel>
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
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(131, 197, true);
            WriteLiteral("<style>\r\n    body {\r\n        background-color: #f5f5f5;\r\n    }\r\n    .form-signin {\r\n        width: 100%;\r\n        max-width: 330px;\r\n        padding: 15px;\r\n        margin: auto;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(328, 4044, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50bd45a2b94440a78d83871770876f6d", async() => {
                BeginContext(354, 61, true);
                WriteLiteral("\r\n<h1>Редактирование заказа</h1>\r\n<div class=\"form-signin\">\r\n");
                EndContext();
#line 21 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
     using (Html.BeginForm())
    {
        
        

#line default
#line hidden
                BeginContext(472, 28, false);
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
#line 24 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
                                     
        
        // Название книги

#line default
#line hidden
                BeginContext(539, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(586, 54, false);
#line 28 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.BookId, "Название книги"));

#line default
#line hidden
                EndContext();
                BeginContext(640, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(655, 136, false);
#line 29 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.DropDownListFor(model => model.BookId, new SelectList(Model.Books, "Value", "Text"), 
                new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(791, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(806, 48, false);
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.BookId));

#line default
#line hidden
                EndContext();
                BeginContext(854, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 33 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        // Клиент

#line default
#line hidden
                BeginContext(901, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(948, 55, false);
#line 36 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.CustomerId, "Имя клиента"));

#line default
#line hidden
                EndContext();
                BeginContext(1003, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1018, 142, false);
#line 37 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.DropDownListFor(model => model.CustomerId, new SelectList(Model.Clients, "Value", "Text"), 
                new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1160, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1175, 52, false);
#line 39 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.CustomerId));

#line default
#line hidden
                EndContext();
                BeginContext(1227, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 41 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        
        // Продавец

#line default
#line hidden
                BeginContext(1286, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1333, 57, false);
#line 45 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.StuffId, "Имя пользователя"));

#line default
#line hidden
                EndContext();
                BeginContext(1390, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1405, 137, false);
#line 46 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.DropDownListFor(model => model.StuffId, new SelectList(Model.Users, "Value", "Text"), 
                new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1542, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1557, 49, false);
#line 48 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.StuffId));

#line default
#line hidden
                EndContext();
                BeginContext(1606, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 50 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        
        // Дата доставки

#line default
#line hidden
                BeginContext(1670, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1717, 53, false);
#line 54 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.DateTo, "Дата доставки"));

#line default
#line hidden
                EndContext();
                BeginContext(1770, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1785, 67, false);
#line 55 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.TextBoxFor(model => model.DateTo, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1852, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1867, 48, false);
#line 56 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.DateTo));

#line default
#line hidden
                EndContext();
                BeginContext(1915, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 58 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        
        // Цена книги

#line default
#line hidden
                BeginContext(1976, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2023, 43, false);
#line 62 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.Price, "Цена"));

#line default
#line hidden
                EndContext();
                BeginContext(2066, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2081, 66, false);
#line 63 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.TextBoxFor(model => model.Price, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(2147, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2162, 47, false);
#line 64 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2209, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 66 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        
        // Количество книг

#line default
#line hidden
                BeginContext(2275, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2322, 49, false);
#line 70 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.Count, "Количество"));

#line default
#line hidden
                EndContext();
                BeginContext(2371, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2386, 66, false);
#line 71 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.TextBoxFor(model => model.Count, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(2452, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2467, 47, false);
#line 72 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(2514, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 74 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        
        // Статус заказа

#line default
#line hidden
                BeginContext(2578, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2625, 46, false);
#line 78 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.Status, "Статус"));

#line default
#line hidden
                EndContext();
                BeginContext(2671, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2686, 150, false);
#line 79 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.DropDownListFor(model => model.Status, new SelectList(new string[] {"Доставлен", "Не доставлен"}), 
                new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(2836, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2851, 48, false);
#line 81 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(2899, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 83 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
        
        // Курьер

#line default
#line hidden
                BeginContext(2946, 46, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(2993, 47, false);
#line 86 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.LabelFor(model => model.Courier, "Курьер"));

#line default
#line hidden
                EndContext();
                BeginContext(3040, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3055, 68, false);
#line 87 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.TextBoxFor(model => model.Courier, new {@class="form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(3123, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3138, 49, false);
#line 88 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.Courier));

#line default
#line hidden
                EndContext();
                BeginContext(3187, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
                BeginContext(3215, 148, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-success btn-block\" value=\"Редактировать заказ\"/>\r\n        </div>\r\n");
                EndContext();
#line 94 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\EditOrder.cshtml"
    }

#line default
#line hidden
                BeginContext(3370, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
                DefineSection("scripts", async() => {
                    BeginContext(3395, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                    BeginContext(3403, 234, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a5f974194df4d8692a4d4047ee98b0e", async() => {
                        BeginContext(3436, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(3446, 71, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f09b289c2a8049989cb9d80fda729eb3", async() => {
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
                        BeginContext(3517, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(3527, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a0875d0569436fa5c8696de27635b2", async() => {
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
                        BeginContext(3617, 6, true);
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
                    BeginContext(3637, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(3643, 717, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e9c75429154a57bec383e32f8aaa3e", async() => {
                        BeginContext(3683, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(3693, 277, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31d797397a4545fc9760139816c850cf", async() => {
                            BeginContext(3951, 10, true);
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
                        BeginContext(3970, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(3980, 360, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92e2accbad1240c2a460c37c9a0c26a7", async() => {
                            BeginContext(4321, 10, true);
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
                        BeginContext(4340, 6, true);
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
                    BeginContext(4360, 2, true);
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
            BeginContext(4372, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_shop2.ViewModels.EditOrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
