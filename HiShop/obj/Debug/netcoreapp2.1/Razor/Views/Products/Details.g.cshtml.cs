#pragma checksum "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0b2b0e8de9484fe343b239ff9429384141934b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a0b2b0e8de9484fe343b239ff9429384141934b", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de869a20bf865f147f1447ec25d5858d4fa88d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HiShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "نمایش جزییات محصول";

#line default
#line hidden
            BeginContext(86, 44, true);
            WriteLiteral("<br class=\"my-3\" />\r\n<h2 class=\"text-right\">");
            EndContext();
            BeginContext(131, 17, false);
#line 7 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 178, true);
            WriteLiteral(" </h2>\r\n<hr />\r\n\r\n<table class=\"table table-bordered table-hover table-striped table-info text-center table-sm\">\r\n    <tbody>\r\n        <tr>\r\n            <td class=\"align-middle\">");
            EndContext();
            BeginContext(327, 37, false);
#line 13 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                                Write(Html.DisplayNameFor(m => m.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(364, 27, true);
            WriteLiteral("</td>\r\n            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 391, "\"", 413, 1);
#line 14 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
WriteAttributeValue("", 397, Model.ImagePath, 397, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 414, "\"", 447, 5);
            WriteAttributeValue("", 420, "سایت", 420, 4, true);
            WriteAttributeValue(" ", 424, "های", 425, 4, true);
            WriteAttributeValue(" ", 428, "شاپ", 429, 4, true);
            WriteAttributeValue(" ", 432, "-", 433, 2, true);
#line 14 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
WriteAttributeValue(" ", 434, Model.Title, 435, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 448, "\"", 483, 5);
            WriteAttributeValue("", 456, "سایت", 456, 4, true);
            WriteAttributeValue(" ", 460, "های", 461, 4, true);
            WriteAttributeValue(" ", 464, "شاپ", 465, 4, true);
            WriteAttributeValue(" ", 468, "-", 469, 2, true);
#line 14 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
WriteAttributeValue(" ", 470, Model.Title, 471, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(484, 68, true);
            WriteLiteral(" class=\"w-75\" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(553, 33, false);
#line 17 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.Title));

#line default
#line hidden
            EndContext();
            BeginContext(586, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(610, 11, false);
#line 18 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(621, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(674, 33, false);
#line 21 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.CatId));

#line default
#line hidden
            EndContext();
            BeginContext(707, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(731, 20, false);
#line 22 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Model.Category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(751, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(804, 36, false);
#line 25 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.IsExists));

#line default
#line hidden
            EndContext();
            BeginContext(840, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 27 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                 if (Model.IsExists)
                {
                    

#line default
#line hidden
            BeginContext(948, 3, true);
            WriteLiteral("بلی");
            EndContext();
#line 29 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                                    
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1046, 3, true);
            WriteLiteral("خیر");
            EndContext();
#line 33 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(1077, 64, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1142, 41, false);
#line 38 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.NumberInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1207, 19, false);
#line 39 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Model.NumberInStock);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1279, 33, false);
#line 42 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1336, 11, false);
#line 43 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 57, true);
            WriteLiteral(" ریال</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1405, 41, false);
#line 46 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.Specification));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1470, 19, false);
#line 47 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
           Write(Model.Specification);

#line default
#line hidden
            EndContext();
            BeginContext(1489, 70, true);
            WriteLiteral(" </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<br class=\"my-2\" />\r\n\r\n");
            EndContext();
#line 53 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
 if (User.IsInRole("مدیر محصولات"))
{

#line default
#line hidden
            BeginContext(1599, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1603, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91c0a1d9b2e4a06bcca9563f183b57c", async() => {
                BeginContext(1681, 82, true);
                WriteLiteral("\r\n        <i class=\"fas fa-edit align-middle\"></i>\r\n        ویرایش این محصول\r\n    ");
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
#line 55 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1767, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1773, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e3abf3c0e7436bb487bc279c9c4d00", async() => {
                BeginContext(1852, 80, true);
                WriteLiteral("\r\n        <i class=\"fas fa-trash align-middle\"></i>\r\n        حذف این محصول\r\n    ");
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
#line 59 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
                             WriteLiteral(Model.Id);

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
            BeginContext(1936, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Products\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1941, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c990ff6fe80c476fa0621a0aee51e085", async() => {
                BeginContext(1992, 77, true);
                WriteLiteral("\r\n    <i class=\"fas fa-share align-middle\"></i>\r\n    بازگشت به لیست محصولات\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HiShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
