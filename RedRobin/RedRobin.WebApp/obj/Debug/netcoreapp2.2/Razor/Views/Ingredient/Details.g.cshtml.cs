#pragma checksum "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f216203b975ef049a9999d64bbdbd108f23388a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredient_Details), @"mvc.1.0.view", @"/Views/Ingredient/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ingredient/Details.cshtml", typeof(AspNetCore.Views_Ingredient_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f216203b975ef049a9999d64bbdbd108f23388a9", @"/Views/Ingredient/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a62759eec34df1f5fbe6a983b50ea8e82d10402", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredient_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RedRobin.WebApp.Models.Ingredient>>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 31, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f216203b975ef049a9999d64bbdbd108f23388a93912", async() => {
                BeginContext(154, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 38, false);
#line 16 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 40, false);
#line 19 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 39, false);
#line 22 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(490, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(546, 40, false);
#line 25 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(586, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(642, 46, false);
#line 28 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(688, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(806, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(855, 37, false);
#line 37 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(892, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(948, 39, false);
#line 40 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(987, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1043, 38, false);
#line 43 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1137, 39, false);
#line 46 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1232, 45, false);
#line 49 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1333, 65, false);
#line 52 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1419, 71, false);
#line 53 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1511, 69, false);
#line 54 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Ingredient\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1619, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RedRobin.WebApp.Models.Ingredient>> Html { get; private set; }
    }
}
#pragma warning restore 1591