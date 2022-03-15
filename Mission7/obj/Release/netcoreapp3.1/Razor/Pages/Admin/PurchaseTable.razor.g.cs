#pragma checksum "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fb645b98fcb906070a26f7e79f808bc78ef2551"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    public partial class PurchaseTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "colspan", "5");
            __builder.AddAttribute(9, "class", "text-center");
            __builder.AddContent(10, 
#nullable restore
#line 5 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<tr>\r\n            <th colspan=\"1\" class=\"text-center\">Name</th>\r\n            <th colspan=\"1\" class=\"text-center\">OrderID</th>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
     if (Purchases?.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
         foreach (Checkout c in Purchases)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                     c.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 19 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                     c.CheckoutId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<th class=\"text-center\">Book</th>\r\n                ");
            __builder.AddMarkupContent(27, "<th class=\"text-center\">Quantity</th>\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                                                                      x => PurchaseSelected.InvokeAsync(c.CheckoutId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 23 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                                                                                                                         ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 27 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
             foreach (BasketLineItem bli in c.Lines)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                    <td colspan=\"2\"></td>\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 31 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                         bli.Book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 32 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
                         bli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 34 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "        ");
            __builder.AddMarkupContent(48, "<tr>\r\n            <td colspan=\"5\" class=\"text-center\">There are no orders.</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\PurchaseTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Purchases";
    [Parameter]
    public IEnumerable<Checkout> Purchases { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> PurchaseSelected { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591