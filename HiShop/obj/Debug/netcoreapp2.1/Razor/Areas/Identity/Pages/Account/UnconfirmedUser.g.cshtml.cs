#pragma checksum "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\Account\UnconfirmedUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3339f892d91f4122fff0d1606e3b60ec5adf8e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HiShop.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_UnconfirmedUser), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/UnconfirmedUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/UnconfirmedUser.cshtml", typeof(HiShop.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_UnconfirmedUser), null)]
namespace HiShop.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\_ViewImports.cshtml"
using HiShop.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HiShop.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3339f892d91f4122fff0d1606e3b60ec5adf8e70", @"/Areas/Identity/Pages/Account/UnconfirmedUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03c2678c94ae74b037157cbc3d628694ab079e5", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e51a85dc5f1cb830d8a88b41a6fcc6761b894c3", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_UnconfirmedUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\Account\UnconfirmedUser.cshtml"
  
    ViewData["Title"] = "حساب کاربری تایید نشده";

#line default
#line hidden
            BeginContext(94, 338, true);
            WriteLiteral(@"
<header class=""text-right mt-5"">
    <div class=""alert alert-success"">
        <h5>
            کاربر گرامی؛
            <br />
            با تشکر از عضویت شما، خواهشمند است جهت تایید و فعالسازی حساب کاربری خود ، ابتدا به ایمیل خود مراجعه نموده و سپس بر روی لینک موجود در آن کلیک نمایید.
        </h5>
        <hr />

        ");
            EndContext();
            BeginContext(432, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b7c2c9b15944f9883e85936552add52", async() => {
                BeginContext(452, 185, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-info\">\r\n                <i class=\"fa fa-paper-plane\"></i>\r\n                ارسال مجدد ایمیل فعال سازی\r\n            </button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(644, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\Account\UnconfirmedUser.cshtml"
     if (ViewData["EmailStatus"] != null)
    {

#line default
#line hidden
            BeginContext(710, 152, true);
            WriteLiteral("        <hr />\r\n        <div class=\"alert alert-warning\">\r\n            <h5>\r\n                <i class=\"fas fa-check align-middle\"></i>\r\n                ");
            EndContext();
            BeginContext(863, 23, false);
#line 30 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\Account\UnconfirmedUser.cshtml"
           Write(ViewData["EmailStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(886, 37, true);
            WriteLiteral("\r\n            </h5>\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Areas\Identity\Pages\Account\UnconfirmedUser.cshtml"
    }

#line default
#line hidden
            BeginContext(930, 13, true);
            WriteLiteral("\r\n\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UnconfirmedUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UnconfirmedUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UnconfirmedUserModel>)PageContext?.ViewData;
        public UnconfirmedUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
