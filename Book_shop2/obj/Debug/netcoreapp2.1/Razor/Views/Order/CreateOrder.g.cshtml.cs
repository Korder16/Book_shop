#pragma checksum "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6264f42539ada892771211f6f0789bea5aacf894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CreateOrder), @"mvc.1.0.view", @"/Views/Order/CreateOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/CreateOrder.cshtml", typeof(AspNetCore.Views_Order_CreateOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6264f42539ada892771211f6f0789bea5aacf894", @"/Views/Order/CreateOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae5c67d4a3169754ec88f733fd8c749c2fcdec76", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CreateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book_shop2.Models.order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 144, true);
            WriteLiteral("<h2 style=\"display: flex; justify-content: center\">Новый заказ</h2>\r\n<div style=\"display: flex; justify-content: center; align-items: center\">\r\n");
            EndContext();
#line 8 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(279, 55, false);
#line 10 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Book_id, "Название книги"));

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                                
        ;

#line default
#line hidden
            BeginContext(347, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(371, 38, false);
#line 13 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Book_id));

#line default
#line hidden
            EndContext();
#line 13 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                               
        ;

#line default
#line hidden
            BeginContext(422, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(451, 51, false);
#line 16 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Customer_id, "Клиент"));

#line default
#line hidden
            EndContext();
#line 16 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                            
        ;

#line default
#line hidden
            BeginContext(515, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(539, 42, false);
#line 19 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Customer_id));

#line default
#line hidden
            EndContext();
            BeginContext(593, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(622, 51, false);
#line 22 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Stuff_id, "Сотрудник"));

#line default
#line hidden
            EndContext();
#line 22 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                            
        ;

#line default
#line hidden
            BeginContext(686, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(710, 39, false);
#line 25 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Stuff_id));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                
        ;

#line default
#line hidden
            BeginContext(762, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(791, 52, false);
#line 28 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Date_on, "Дата заказа"));

#line default
#line hidden
            EndContext();
#line 28 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                             
        ;

#line default
#line hidden
            BeginContext(856, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(880, 38, false);
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Date_on));

#line default
#line hidden
            EndContext();
#line 31 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                               
        ;

#line default
#line hidden
            BeginContext(931, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(960, 54, false);
#line 34 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Date_to, "Дата доставки"));

#line default
#line hidden
            EndContext();
#line 34 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                               
        ;

#line default
#line hidden
            BeginContext(1027, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1051, 38, false);
#line 37 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Date_to));

#line default
#line hidden
            EndContext();
#line 37 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                               
        ;

#line default
#line hidden
            BeginContext(1102, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(1131, 49, false);
#line 40 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Count, "Количество"));

#line default
#line hidden
            EndContext();
#line 40 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                          
        ;

#line default
#line hidden
            BeginContext(1193, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1217, 36, false);
#line 43 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Count));

#line default
#line hidden
            EndContext();
#line 43 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                             
        ;

#line default
#line hidden
            BeginContext(1266, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(1295, 43, false);
#line 46 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Prise, "Цена"));

#line default
#line hidden
            EndContext();
#line 46 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                    
        ;

#line default
#line hidden
            BeginContext(1351, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1375, 36, false);
#line 49 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Prise));

#line default
#line hidden
            EndContext();
#line 49 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                             
        ;

#line default
#line hidden
            BeginContext(1424, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(1453, 47, false);
#line 52 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Cost, "Стоимость"));

#line default
#line hidden
            EndContext();
#line 52 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                        
        ;

#line default
#line hidden
            BeginContext(1513, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1537, 35, false);
#line 55 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Cost));

#line default
#line hidden
            EndContext();
#line 55 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                            
        ;

#line default
#line hidden
            BeginContext(1585, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(1614, 46, false);
#line 58 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Status, "Cтатус"));

#line default
#line hidden
            EndContext();
#line 58 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                       
        ;

#line default
#line hidden
            BeginContext(1673, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1697, 37, false);
#line 61 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Status));

#line default
#line hidden
            EndContext();
#line 61 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                              
        ;

#line default
#line hidden
            BeginContext(1747, 20, true);
            WriteLiteral("        <br/><br/>\r\n");
            EndContext();
            BeginContext(1776, 52, false);
#line 64 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.LabelFor(model => model.Courier_name, "Курьер"));

#line default
#line hidden
            EndContext();
#line 64 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                             
        ;

#line default
#line hidden
            BeginContext(1841, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1865, 43, false);
#line 67 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
   Write(Html.EditorFor(model => model.Courier_name));

#line default
#line hidden
            EndContext();
#line 67 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
                                                    
        ;

#line default
#line hidden
            BeginContext(1921, 15, true);
            WriteLiteral("        <br/>\r\n");
            EndContext();
            BeginContext(1946, 129, true);
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-primary\" value=\"Добавить\"/>                                                        \r\n");
            EndContext();
#line 72 "C:\Users\Islam\RiderProjects\Book_shop2\Book_shop2\Views\Order\CreateOrder.cshtml"
    }

#line default
#line hidden
            BeginContext(2082, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_shop2.Models.order> Html { get; private set; }
    }
}
#pragma warning restore 1591
