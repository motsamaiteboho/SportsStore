#pragma checksum "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed8a572f6e2dedd5d7aa81cd6086fe79323b905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportsStore.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace SportsStore.Pages
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
#line 2 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
           [Authorize(Roles ="Customers")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed8a572f6e2dedd5d7aa81cd6086fe79323b905", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdf46fecccb5754c5440e0964ef4989bcd0d216b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your cart</h2>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Quantity</th>
            <th>Item</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
#nullable restore
#line 19 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
                                   Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 20 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
                                 Write(line.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 21 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
                                  Write(line.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
                Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed8a572f6e2dedd5d7aa81cd6086fe79323b9057935", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"ProductID\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 958, "\"", 1021, 1);
#nullable restore
#line 28 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
WriteAttributeValue("", 998, line.Product.ProductID, 998, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 1088, "\"", 1144, 1);
#nullable restore
#line 30 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
WriteAttributeValue("", 1128, Model.ReturnUrl, 1128, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                            Remove\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr class=\"font-weight-bold\">\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
           Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1745, 1);
#nullable restore
#line 49 "C:\Users\Motsa\Downloads\SportsStore_AfterSU4_9\SportsStore_AfterSU4_9\SportsStore\Pages\Cart.cshtml"
WriteAttributeValue("", 1729, Model.ReturnUrl, 1729, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue shopping</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed8a572f6e2dedd5d7aa81cd6086fe79323b90512066", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel>)PageContext?.ViewData;
        public CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591