#pragma checksum "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f410d2703d6ba24ce2a05f4046c43f43b9988d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\_ViewImports.cshtml"
using E_CommercePortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\_ViewImports.cshtml"
using E_CommercePortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f410d2703d6ba24ce2a05f4046c43f43b9988d1", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c699f65f038f3237b1d414fae50f141ef55008f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductRepository.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n");
#nullable restore
#line 10 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Administrator"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f410d2703d6ba24ce2a05f4046c43f43b9988d14447", async() => {
                WriteLiteral("Add new Product");
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
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 15 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"m-3\">\r\n    <a class=\"btn btn-primary m-2\"");
            BeginWriteAttribute("href", " href=\"", 409, "\"", 449, 1);
#nullable restore
#line 17 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
WriteAttributeValue("", 416, Url.Action("GetById", "Product"), 416, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Search By Product Id</a>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 507, "\"", 549, 1);
#nullable restore
#line 18 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
WriteAttributeValue("", 514, Url.Action("GetByName", "Product"), 514, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Search By Product Name</a>\r\n</div>\r\n");
#nullable restore
#line 20 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Administrator"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Image_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { proId = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 71 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { proId = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 72 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { proId = item.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 73 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                   Write(Html.ActionLink("DetailsByName", "DetailsByName", new { proName = item.ProductName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n\r\n            </tr>\r\n");
#nullable restore
#line 78 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n\r\n</table>\r\n");
#nullable restore
#line 83 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Customer"))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <span class=\"row mb-2 border\">\r\n            <div class=\"col-4 \">\r\n                <img class=\"d-block w-50 border rounded-3\"");
            BeginWriteAttribute("src", " src=\"", 2991, "\"", 3043, 1);
#nullable restore
#line 91 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
WriteAttributeValue("", 2997, Html.DisplayFor(modelItem => item.Image_name), 2997, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n\r\n            </div>\r\n            <div class=\"col-8 \">\r\n                <span>Product Id :  ");
#nullable restore
#line 95 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                <span>Product Name : ");
#nullable restore
#line 97 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                <br />\r\n                <span>Description :  ");
#nullable restore
#line 99 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                <span>Product Price :  ");
#nullable restore
#line 101 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                <span>Rating :  ");
#nullable restore
#line 103 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </span>\r\n\r\n    </div>\r\n");
#nullable restore
#line 108 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Product\Index.cshtml"
 
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductRepository.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
