#pragma checksum "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61eb716716ed5514aaa57865f3812faee51685cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
#line 1 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\_ViewImports.cshtml"
using RedRobin.WebApp;

#line default
#line hidden
#line 2 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\_ViewImports.cshtml"
using RedRobin.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61eb716716ed5514aaa57865f3812faee51685cf", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a62759eec34df1f5fbe6a983b50ea8e82d10402", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RedRobin.WebApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 116, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #fbefcc;\r\n    }\r\n</style>\r\n\r\n<h1>List of Products</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(213, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61eb716716ed5514aaa57865f3812faee51685cf3982", async() => {
                BeginContext(236, 18, true);
                WriteLiteral("Create New Product");
                EndContext();
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
            EndContext();
            BeginContext(258, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 38, false);
#line 22 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(389, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(445, 47, false);
#line 25 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.productName));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 40, false);
#line 28 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(588, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(644, 45, false);
#line 31 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(689, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(745, 46, false);
#line 34 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(791, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(926, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(987, 37, false);
#line 44 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1092, 46, false);
#line 47 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.productName));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1206, 39, false);
#line 50 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1313, 44, false);
#line 53 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalCost));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1425, 45, false);
#line 56 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1822, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 64 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1852, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RedRobin.WebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
