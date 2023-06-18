#pragma checksum "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41c6e329da346a82f5553e5df322cc1641d55d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\_ViewImports.cshtml"
using LibraryCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\_ViewImports.cshtml"
using LibraryCRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\_ViewImports.cshtml"
using LibraryCRUD.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c6e329da346a82f5553e5df322cc1641d55d4e", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a525161c0f68e3cbf36e74465301b745feab11", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Books";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
  
    bool check(ICollection<UserAccount>users,int? id)
    {
        if (!users.Any())
            return false;

        foreach(var user in users )
        {
            if (user.Id == id)
                return true;
        }
        return false;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
  
    if(ViewBag.IsAll)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>\r\n            <i class=\"bi bi-book\"></i>\r\n            Books\r\n        </h2>\r\n        <hr />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c6e329da346a82f5553e5df322cc1641d55d4e6591", async() => {
                WriteLiteral("\r\n            <i class=\"bi bi-plus\"></i>\r\n            Add New Book\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
    }
    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>\r\n            <i class=\"bi bi-bookmark-heart\"></i>\r\n            Favorit Books\r\n        </h2>\r\n        <hr />\r\n");
#nullable restore
#line 44 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mt-4\">\r\n\r\n");
#nullable restore
#line 48 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
     if (!Model.Any())
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        <i class=\"bi bi-exclamation-triangle-fill\"></i>\r\n        No Books Found!\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
     }
     else
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 58 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
             foreach (var book in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col col-12\">\r\n                    <div class=\"card mb-3\" >\r\n                        <div class=\"row no-gutters\">\r\n                            <div class=\"col-md-2 cover\"");
            BeginWriteAttribute("style", " style=\"", 1315, "\"", 1401, 3);
            WriteAttributeValue("", 1323, "background-image:url(data:image\\/*;base64,", 1323, 42, true);
#nullable restore
#line 63 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
WriteAttributeValue("", 1365, Convert.ToBase64String(book.Cover), 1365, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1400, ")", 1400, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <div class=""col-md-10"">
                                <div class=""card-body d-flex flex-column justify-content-between h-100"" >
                                    <div class=""mb-2"">
                                        <div class=""d-flex justify-content-between"">
                                            <h5 class=""card-title"">");
#nullable restore
#line 68 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                              Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 68 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                           Write(book.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                                            <span class=\"text-danger\">\r\n                                                <i");
            BeginWriteAttribute("onclick", " onclick=\"", 1933, "\"", 1964, 3);
            WriteAttributeValue("", 1943, "Change(this,", 1943, 12, true);
#nullable restore
#line 70 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
WriteAttributeValue("", 1955, book.Id, 1955, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1963, ")", 1963, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"fav\"");
            BeginWriteAttribute("class", " class=\"", 1974, "\"", 2056, 2);
            WriteAttributeValue("", 1982, "bi", 1982, 2, true);
#nullable restore
#line 70 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
WriteAttributeValue(" ", 1984, check(book.FavoritByUsers,ViewBag.userId)?"bi-heart-fill":"bi-heart", 1985, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </span>\r\n                                        </div>\r\n                                        \r\n                                        <h6 class=\"card-subtitle text-muted mb-2\">");
#nullable restore
#line 74 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                             Write(book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"card-text text-justify\">");
#nullable restore
#line 75 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                      Write(book.Description.Length>300?$"{book.Description.Substring(0,300)} ... See more": book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class="" d-flex justify-content-between"">
                                        <p class=""card-text mb-0 mt-2"">
                                            <i class=""bi bi-star-fill text-warning""></i>
                                            <small class=""text-muted"">");
#nullable restore
#line 80 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                 Write(book.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </p>\r\n                                        <div>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c6e329da346a82f5553e5df322cc1641d55d4e14186", async() => {
                WriteLiteral("\r\n                                                    <i class=\"bi bi-ticket-detailed\"></i>\r\n                                                    Details\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                                                                                  WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                             if (User.Identity.IsAuthenticated)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41c6e329da346a82f5553e5df322cc1641d55d4e17278", async() => {
                WriteLiteral("\r\n                                                    <i class=\"bi bi-pencil-square\"></i>\r\n                                                    Edit\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                                                                             WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 93 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                                                                                            Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    <i class=\"bi bi-trash\"></i>\r\n                                                    Delete\r\n                                                </a>\r\n");
#nullable restore
#line 97 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 106 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
             }   

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 108 "C:\Users\RIZK\source\repos\LibraryCRUD\LibraryCRUD\Views\Book\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
     
        function Change(ele,bookId) {
            if (ele.classList.contains(""bi-heart-fill"")) 
            {
                ele.classList.remove(""bi-heart-fill"");
                ele.classList.add(""bi-heart"");
                $.ajax({
                    url: '/Account/DeleteFromFavorit/' + bookId,
                    success: function () {

                    },
                    error: function () {
                        toastr.error('Something went wrong!');

                    }
                });
               
            }
            else {
                ele.classList.remove(""bi-heart"")
                ele.classList.add(""bi-heart-fill"")

                $.ajax({
                    url: '/Account/AddToFavorit/' + bookId,
                    success: function () {

                    },
                    error: function () {
                        toastr.error('Something went wrong!');

                    }
                });
    ");
                WriteLiteral(@"            
                //routes.MapRoute(
                //    url: ""{controller}/{action}/{id}"",
                //    defaults: new { controller = ""AccountController"", action = ""DeleteToFavorit"", id = bookId }
                //);
            }
        }

        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);
                bootbox.confirm({
                    message: 'Are you sure that you need to delete this book',
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.");
                WriteLiteral(@"ajax({
                                url: '/Book/Delete/' + btn.data('id'),
                                success: function () {
                                    btn.parents('.col-12').fadeOut();
                                    toastr.success(""Book deleted"");
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                            });
                        }
                    }
                });
                
            });

            

        });

       
    </script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591