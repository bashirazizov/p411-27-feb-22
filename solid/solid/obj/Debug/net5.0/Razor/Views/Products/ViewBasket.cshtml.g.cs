#pragma checksum "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa01b34e837bbd8b8d933af7a5636d64a621298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ViewBasket), @"mvc.1.0.view", @"/Views/Products/ViewBasket.cshtml")]
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
#line 1 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\_ViewImports.cshtml"
using solid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\_ViewImports.cshtml"
using solid.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\_ViewImports.cshtml"
using solid.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa01b34e837bbd8b8d933af7a5636d64a621298", @"/Views/Products/ViewBasket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507093c4e2824873dcbb6d61c9de9ebb8e7d3baa", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ViewBasket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section>
    <div class=""wrapper"">
        <div class=""inner"">
            <h4>Basket</h4>

            <div class=""table-wrapper basket-table"">
                <table class=""alt"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Unit Price</th>
                            <th>Count</th>
                            <th>Total Price</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 18 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                         if (Model == null || Model.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"4\">\r\n                                    Sizin basket bosdur.\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                             foreach (BasketItem item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 31 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                                   Write(item.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 32 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                                    Write(Utils.coinToMoney(item.product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1311, "\"", 1359, 2);
            WriteAttributeValue("", 1318, "/products/decreaseBasket/", 1318, 25, true);
#nullable restore
#line 34 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
WriteAttributeValue("", 1343, item.product.Id, 1343, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"decrease-count lnr lnr-chevron-down\">\r\n                                        </a>\r\n                                        <span class=\"actualCount\">");
#nullable restore
#line 36 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                                                             Write(item.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1581, "\"", 1629, 2);
            WriteAttributeValue("", 1588, "/products/increaseBasket/", 1588, 25, true);
#nullable restore
#line 37 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
WriteAttributeValue("", 1613, item.product.Id, 1613, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"increase-count lnr lnr-chevron-up\">\r\n                                        </a>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                                    Write(Utils.coinToMoney(item.totalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td colspan=\"3\"></td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\Bashir Azizov\Desktop\p411\p411-27-feb-22\solid\solid\Views\Products\ViewBasket.cshtml"
                            Write(Utils.coinToMoney(ViewBag.basketTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        </tr>
                    </tfoot>
                </table>
                <div>
                    <a href=""#"" class=""button primary"">Buy</a>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
