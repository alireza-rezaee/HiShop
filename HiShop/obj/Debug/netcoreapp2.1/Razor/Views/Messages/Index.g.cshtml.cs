#pragma checksum "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db870a14d432411fdcd68782e72dab1fc86fa6b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Index.cshtml", typeof(AspNetCore.Views_Messages_Index))]
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
#line 1 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\_ViewImports.cshtml"
using HiShop;

#line default
#line hidden
#line 2 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\_ViewImports.cshtml"
using HiShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db870a14d432411fdcd68782e72dab1fc86fa6b3", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de869a20bf865f147f1447ec25d5858d4fa88d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
  
    ViewData["Title"] = "نمایش پیام ها";

#line default
#line hidden
            DefineSection("Head", async() => {
                BeginContext(92, 111, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css\" />\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(206, 44, true);
            WriteLiteral("<br class=\"my-3\" />\r\n<h2 class=\"text-right\">");
            EndContext();
            BeginContext(251, 17, false);
#line 10 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(268, 16, true);
            WriteLiteral(" </h2>\r\n<hr />\r\n");
            EndContext();
#line 12 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(307, 91, true);
            WriteLiteral("    <div class=\"alert alert-warning text-center\">هیچ پیامی در فروشگاه ثبت نشده است.</div>\r\n");
            EndContext();
#line 15 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(410, 241, true);
            WriteLiteral("    <table class=\"table table-bordered table-hover table-striped table-info text-center table-sm\">\r\n        <thead class=\"table-dark text-danger\" style=\"font-size:large\">\r\n            <tr>\r\n                <td>ردیف</td>\r\n                <td>");
            EndContext();
            BeginContext(652, 37, false);
#line 22 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.IsStarred));

#line default
#line hidden
            EndContext();
            BeginContext(689, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(717, 34, false);
#line 23 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.IsRead));

#line default
#line hidden
            EndContext();
            BeginContext(751, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(779, 32, false);
#line 24 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(811, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(839, 33, false);
#line 25 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(872, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(900, 35, false);
#line 26 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(935, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(963, 42, false);
#line 27 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.RegisteredTime));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 124, true);
            WriteLiteral("</td>\r\n                <td>جزییات</td>\r\n                <td>حذف</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
               var i = 1;

#line default
#line hidden
            BeginContext(1157, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 34 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1214, 67, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(1282, 1, false);
#line 37 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 56, true);
            WriteLiteral("</td>\r\n\r\n                    <td class=\"align-middle\">\r\n");
            EndContext();
#line 40 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                         if (item.IsStarred)
                        {

#line default
#line hidden
            BeginContext(1410, 38, true);
            WriteLiteral("<a href=\"javascript:void(0)\" data-id=\"");
            EndContext();
            BeginContext(1449, 7, false);
#line 41 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 91, true);
            WriteLiteral("\" data-change-code=\"0\"><i class=\"fas fa-2x fa-star text-warning\" title=\"حذف ستاره\"></i></a>");
            EndContext();
#line 41 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                                                                                  }
                        else
                        {

#line default
#line hidden
            BeginContext(1605, 38, true);
            WriteLiteral("<a href=\"javascript:void(0)\" data-id=\"");
            EndContext();
            BeginContext(1644, 7, false);
#line 43 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1651, 96, true);
            WriteLiteral("\" data-change-code=\"1\"><i class=\"far fa-2x fa-star text-warning\" title=\"ستاره دار کردن\"></i></a>");
            EndContext();
#line 43 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                                                                                       }

#line default
#line hidden
            BeginContext(1750, 76, true);
            WriteLiteral("                    </td>\r\n\r\n                    <td class=\"align-middle\">\r\n");
            EndContext();
#line 47 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                         if (item.IsRead)
                        {

#line default
#line hidden
            BeginContext(1894, 38, true);
            WriteLiteral("<a href=\"javascript:void(0)\" data-id=\"");
            EndContext();
            BeginContext(1933, 7, false);
#line 48 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1940, 119, true);
            WriteLiteral("\" data-change-code=\"2\"><i class=\"far fa-2x fa-envelope-open text-secondary\" title=\"علامت به عنوان خوانده نشده\"></i></a>");
            EndContext();
#line 48 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                                                                                                              }
                        else
                        {

#line default
#line hidden
            BeginContext(2117, 38, true);
            WriteLiteral("<a href=\"javascript:void(0)\" data-id=\"");
            EndContext();
            BeginContext(2156, 7, false);
#line 50 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 113, true);
            WriteLiteral("\" data-change-code=\"3\"><i class=\"far fa-2x fa-envelope text-secondary\" title=\"علامت به عنوان خوانده شده\"></i></a>");
            EndContext();
#line 50 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                                                                                                        }

#line default
#line hidden
            BeginContext(2279, 74, true);
            WriteLiteral("                    </td>\r\n\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(2354, 9, false);
#line 53 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                        Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2363, 80, true);
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2443, "\"", 2468, 2);
            WriteAttributeValue("", 2450, "mailto:", 2450, 7, true);
#line 55 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
WriteAttributeValue("", 2457, item.Email, 2457, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2469, 26, true);
            WriteLiteral(" title=\"پاسخ به این پیام\">");
            EndContext();
            BeginContext(2496, 10, false);
#line 55 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                         Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2506, 78, true);
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(2585, 12, false);
#line 57 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                        Write(item.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(2597, 52, true);
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
            EndContext();
            BeginContext(2650, 39, false);
#line 58 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                        Write(item.RegisteredTime.ToPersianDateTime());

#line default
#line hidden
            EndContext();
            BeginContext(2689, 78, true);
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        ");
            EndContext();
            BeginContext(2767, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e3455be665646ceb2bce423361949e3", async() => {
                BeginContext(2842, 96, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-2x fa-info-circle\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2942, 100, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
            EndContext();
            BeginContext(3042, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df7776c68290481e89860ce5a3835822", async() => {
                BeginContext(3118, 90, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-2x fa-trash\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3212, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 70 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(3301, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 74 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"

}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(3356, 713, true);
                WriteLiteral(@"

    <script src=""//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>
    <script>
        toastr.options = {
            ""closeButton"": true,
            ""debug"": false,
            ""newestOnTop"": false,
            ""progressBar"": true,
            ""positionClass"": ""toast-top-left"",
            ""preventDuplicates"": false,
            ""onclick"": null,
            ""showDuration"": ""300"",
            ""hideDuration"": ""1000"",
            ""timeOut"": ""10000"",
            ""extendedTimeOut"": ""1000"",
            ""showEasing"": ""swing"",
            ""hideEasing"": ""linear"",
            ""showMethod"": ""fadeIn"",
            ""hideMethod"": ""fadeOut""
        };
    </script>
");
                EndContext();
#line 98 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
     if (TempData["MessageDeleteStatus"] != null)
    {
        

#line default
#line hidden
#line 100 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
         if ((string)TempData["MessageDeleteStatus"] == "OK")
        {

#line default
#line hidden
                BeginContext(4201, 96, true);
                WriteLiteral("            <script>toastr[\"success\"](\"پیام مورد نظر با موفقیت حذف گردید.\", \"های شاپ\");</script>");
                EndContext();
#line 102 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                }
        else
        {

#line default
#line hidden
                BeginContext(4325, 94, true);
                WriteLiteral("            <script>toastr[\"error\"](\"پیام مورد نظر حذف نگردید، لطفاً مجدداً تلاش نمایید. <br> ");
                EndContext();
                BeginContext(4420, 42, false);
#line 105 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                         Write(TempData["MessageDeleteStatus"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(4462, 23, true);
                WriteLiteral("\", \"های شاپ\");</script>");
                EndContext();
#line 105 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                                                                                }

#line default
#line hidden
#line 105 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Messages\Index.cshtml"
                                                                                                                                                                 
    }

#line default
#line hidden
                BeginContext(4495, 1903, true);
                WriteLiteral(@"
    <script>

        $('a[data-change-code]').click(function () {

            var changeElement = $(this);
            var changeType = changeElement.attr('data-change-code');
            $.ajax({
                method: 'get',
                url: '/Messages/ChangeStatus',
                data: { id: changeElement.attr('data-id'), changeCode: changeType },
                success: function () {
                    switch (changeType) {
                        case '0':
                            changeElement
                                .attr('data-change-code', 1)
                                .empty()
                                .html('<i class=""far fa-2x fa-star text-warning"" title=""ستاره دار کردن""></i>');
                            break;
                        case '1':
                            changeElement
                                .attr('data-change-code', 0)
                                .empty()
                                .html('<i class=""fas f");
                WriteLiteral(@"a-2x fa-star text-warning"" title=""حذف ستاره""></i>');
                            break;
                        case '2':
                            changeElement
                                .attr('data-change-code', 3)
                                .empty()
                                .html('<i class=""far fa-2x fa-envelope text-secondary"" title=""علامت به عنوان خوانده شده""></i>');
                            break;
                        case '3':
                            changeElement
                                .attr('data-change-code', 2)
                                .empty()
                                .html('<i class=""far fa-2x fa-envelope-open text-secondary"" title=""علامت به عنوان خوانده نشده""></i>');
                            break;
                    }
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
