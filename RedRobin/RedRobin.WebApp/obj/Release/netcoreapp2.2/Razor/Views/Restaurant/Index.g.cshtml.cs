#pragma checksum "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5909cccda93d58e94cc02e0ce8d82a0508763102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Index), @"mvc.1.0.view", @"/Views/Restaurant/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurant/Index.cshtml", typeof(AspNetCore.Views_Restaurant_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5909cccda93d58e94cc02e0ce8d82a0508763102", @"/Views/Restaurant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a62759eec34df1f5fbe6a983b50ea8e82d10402", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RedRobin.WebApp.Models.Restaurant>>
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
#line 3 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 109, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #fbefcc;\r\n    }\r\n</style>\r\n<h1>Restaurants</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(207, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5909cccda93d58e94cc02e0ce8d82a05087631023982", async() => {
                BeginContext(230, 10, true);
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
            BeginContext(244, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(337, 38, false);
#line 21 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(375, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(431, 44, false);
#line 24 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 41, false);
#line 27 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(572, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(707, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(768, 37, false);
#line 37 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(805, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(873, 43, false);
#line 40 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(916, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(984, 40, false);
#line 43 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    ");
            EndContext();
            BeginContext(1094, 96, false);
#line 47 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
               Write(Html.ActionLink("✎", "Edit", new { id = item.Id }, new { Class = "action add", title = "Edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1215, 101, false);
#line 48 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
               Write(Html.ActionLink("🗑", "Delete", new { id = item.Id }, new { Class = "action add", title = "Delete" }));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 51 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Restaurant\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1371, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RedRobin.WebApp.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591