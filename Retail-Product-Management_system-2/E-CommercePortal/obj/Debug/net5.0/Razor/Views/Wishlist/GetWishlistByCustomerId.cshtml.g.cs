#pragma checksum "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1645d6bc1c7c0c1caf1a37b1755b1f8f58e9e32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wishlist_GetWishlistByCustomerId), @"mvc.1.0.view", @"/Views/Wishlist/GetWishlistByCustomerId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1645d6bc1c7c0c1caf1a37b1755b1f8f58e9e32", @"/Views/Wishlist/GetWishlistByCustomerId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c699f65f038f3237b1d414fae50f141ef55008f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Wishlist_GetWishlistByCustomerId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProceedToBuyRepository.Models.WishList>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
  
    ViewData["Title"] = "GetWishlistByCustomerId";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetWishlistByCustomerId</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1645d6bc1c7c0c1caf1a37b1755b1f8f58e9e324072", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayNameFor(model => model.WishListId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayNameFor(model => model.VendorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayNameFor(model => model.AddedToWishlistDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayFor(modelItem => item.WishListId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayFor(modelItem => item.VendorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.DisplayFor(modelItem => item.AddedToWishlistDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 59 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\GetWishlistByCustomerId.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProceedToBuyRepository.Models.WishList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
