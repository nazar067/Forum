#pragma checksum "F:\c#\Forum\Forum\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340e0f9b12dc17915a41b5649e4218424012e6e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Account.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
namespace WebApplication1.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\c#\Forum\Forum\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340e0f9b12dc17915a41b5649e4218424012e6e0", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Forum.Models.ViewModels.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h1>Register</h1>\n<div style=\"height: 540px; width: 1400px; background-size: 100% 100%; background-image: url(https://wallpaper.dog/large/5486507.png) \">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340e0f9b12dc17915a41b5649e4218424012e6e03985", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340e0f9b12dc17915a41b5649e4218424012e6e04249", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 7 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <div>\n            <div>\n                <div style=\"display:flex\">\n                    <div>\n                        <div>");
#nullable restore
#line 12 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                        Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        ");
#nullable restore
#line 13 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 14 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n                <div>\n                    <div>");
#nullable restore
#line 18 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                    Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                    ");
#nullable restore
#line 19 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
#nullable restore
#line 20 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <div>");
#nullable restore
#line 23 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                    Write(Html.LabelFor(x => x.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                    ");
#nullable restore
#line 24 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(x => x.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
#nullable restore
#line 25 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div style=\"display:flex\">\n                    <div>\n                        <div>");
#nullable restore
#line 29 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                        Write(Html.LabelFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        ");
#nullable restore
#line 30 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                   Write(Html.PasswordFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 31 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div style=\"margin-left: 50px\">\n                        <div>");
#nullable restore
#line 34 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                        Write(Html.LabelFor(x => x.ConfirmPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        ");
#nullable restore
#line 35 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                   Write(Html.PasswordFor(x => x.ConfirmPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 36 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.ConfirmPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                </div>\n            </div>\n            <input type=\"submit\" value=\"Confirm\" class=\"btn btn-primary\" style=\"width:466px; margin-top:20px\" />\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 6 "F:\c#\Forum\Forum\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Forum.Models.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591