#pragma checksum "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a96d5ae8864e774fbfbced5f4648182e88c5858b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wishlist_WishlistDetails), @"mvc.1.0.view", @"/Views/Wishlist/WishlistDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96d5ae8864e774fbfbced5f4648182e88c5858b", @"/Views/Wishlist/WishlistDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c699f65f038f3237b1d414fae50f141ef55008f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Wishlist_WishlistDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProceedToBuyRepository.Models.WishList>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
  
    ViewData["Title"] = "WishlistDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>WishlistDetails</h1>\r\n\r\n<div>\r\n    <h4>WishList</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.WishListId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayFor(model => model.WishListId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayFor(model => model.VendorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.AddedToWishlistDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
       Write(Html.DisplayFor(model => model.AddedToWishlistDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 52 "D:\Cognizant\Retail-Product-Management-System\Retail-Product-Management_system-2\E-CommercePortal\Views\Wishlist\WishlistDetails.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a96d5ae8864e774fbfbced5f4648182e88c5858b8991", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProceedToBuyRepository.Models.WishList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
