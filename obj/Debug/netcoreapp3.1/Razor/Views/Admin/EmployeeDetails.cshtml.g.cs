#pragma checksum "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3374f2fa235b6232d71874580f4e149384cafe6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EmployeeDetails), @"mvc.1.0.view", @"/Views/Admin/EmployeeDetails.cshtml")]
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
#nullable restore
#line 1 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\_ViewImports.cshtml"
using v3x;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\_ViewImports.cshtml"
using v3x.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3374f2fa235b6232d71874580f4e149384cafe6e", @"/Views/Admin/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d929412cffc847897a923b04b958a363db7ac077", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<v3x.Models.People>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeTable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
  
    ViewData["Title"] = "EmployeeDetails";
    Layout = "_Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Employee Details</h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th></th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n        <tr>\n            <td>Name</td>\n            <td>");
#nullable restore
#line 18 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Email</td>\n            <td>");
#nullable restore
#line 22 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Contact No</td>\n            <td>");
#nullable restore
#line 26 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(Model.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Nationality</td>\n            <td>");
#nullable restore
#line 30 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(Model.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Date of Birth</td>\n            <td>");
#nullable restore
#line 34 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(Model.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Address</td>\n            <td>");
#nullable restore
#line 38 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Position</td>\n            <td>");
#nullable restore
#line 42 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
           Write(ViewData["Position"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Base salary</td>\n            <td>RM ");
#nullable restore
#line 46 "D:\Year 3\Sem2 2019\AD\Cammetech-master\Views\Admin\EmployeeDetails.cshtml"
              Write(ViewData["BasePay"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tbody>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3374f2fa235b6232d71874580f4e149384cafe6e6248", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<v3x.Models.People> Html { get; private set; }
    }
}
#pragma warning restore 1591
