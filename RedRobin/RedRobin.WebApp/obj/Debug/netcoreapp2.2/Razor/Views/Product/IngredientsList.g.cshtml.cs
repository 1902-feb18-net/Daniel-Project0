#pragma checksum "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120e60721e0225304d790f55ee2371325f5e64a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_IngredientsList), @"mvc.1.0.view", @"/Views/Product/IngredientsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/IngredientsList.cshtml", typeof(AspNetCore.Views_Product_IngredientsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120e60721e0225304d790f55ee2371325f5e64a2", @"/Views/Product/IngredientsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a62759eec34df1f5fbe6a983b50ea8e82d10402", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_IngredientsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RedRobin.WebApp.Models.Ingredient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
  
    ViewData["Title"] = "IngredientsList";

#line default
#line hidden
            BeginContext(108, 212, true);
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: #fbefcc;\r\n    }\r\n</style>\r\n\r\n<h1>List of Ingredients</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(321, 38, false);
#line 18 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(359, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(427, 40, false);
#line 21 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
               Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(467, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(535, 46, false);
#line 24 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
               Write(Html.DisplayNameFor(model => model.QtyToStock));

#line default
#line hidden
            EndContext();
            BeginContext(581, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(649, 40, false);
#line 27 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
               Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(689, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(757, 46, false);
#line 30 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
               Write(Html.DisplayNameFor(model => model.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(803, 108, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
            EndContext();
#line 37 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(968, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1041, 37, false);
#line 41 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1158, 39, false);
#line 44 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1277, 45, false);
#line 47 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QtyToStock));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1402, 39, false);
#line 50 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1521, 45, false);
#line 53 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Restaurant));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(1737, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1788, 60, false);
#line 60 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
                   Write(Html.ActionLink("Add", "AddIngredient", new {  id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 63 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
            }

#line default
#line hidden
            BeginContext(1915, 51, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(1967, 41, false);
#line 68 "C:\Revature\Project0\Daniel-Project0\RedRobin\RedRobin.WebApp\Views\Product\IngredientsList.cshtml"
   Write(Html.ActionLink("DONE!", "EditTotalCost"));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 14, true);
            WriteLiteral("\r\n    </p>\r\n\r\n");
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
