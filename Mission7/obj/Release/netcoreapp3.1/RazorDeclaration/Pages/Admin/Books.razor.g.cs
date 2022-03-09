// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<iBookRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\coles\Desktop\is403\mission9\Mission7\Pages\Admin\Books.razor"
       
    public iBookRepository repo => Service;
    public IEnumerable<Book> BookData { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }
    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public async Task RemoveBook (Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
