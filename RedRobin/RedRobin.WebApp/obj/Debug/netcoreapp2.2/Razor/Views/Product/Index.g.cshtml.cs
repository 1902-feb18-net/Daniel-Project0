#pragma checksum "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d9f5bf98e08968483de81de3827adbe9ed6a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5d9f5bf98e08968483de81de3827adbe9ed6a26", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a62759eec34df1f5fbe6a983b50ea8e82d10402", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RedRobin.WebApp.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 194, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #fbefcc;\r\n    }\r\n</style>\r\n\r\n<h1>Choose a Restaurant</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(293, 38, false);
#line 19 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(331, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(387, 44, false);
#line 22 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 41, false);
#line 25 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(528, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(646, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(695, 37, false);
#line 34 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(732, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(788, 63, false);
#line 37 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
           Write(Html.ActionLink(item.Location, "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(851, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(907, 40, false);
#line 40 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(947, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\Index.cshtml"
}

#line default
#line hidden
            BeginContext(986, 24, true);
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
