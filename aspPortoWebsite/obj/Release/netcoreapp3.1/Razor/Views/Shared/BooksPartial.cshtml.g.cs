#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fcc9be92027439c15d6c91d8db912c40448c777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BooksPartial), @"mvc.1.0.view", @"/Views/Shared/BooksPartial.cshtml")]
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
#line 1 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\_ViewImports.cshtml"
using aspPortoWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\_ViewImports.cshtml"
using aspPortoWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\_ViewImports.cshtml"
using aspPortoWebsite.Models.ForBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\_ViewImports.cshtml"
using aspPortoWebsite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\_ViewImports.cshtml"
using aspPortoWebsite.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fcc9be92027439c15d6c91d8db912c40448c777", @"/Views/Shared/BooksPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f974e427b9a28649861d05df1247dfc92a82e681", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BooksPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Books>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-6 col-sm-4 col-md-3 col-xl-5col\">\r\n\r\n        <div class=\"product-default\">\r\n\r\n            <figure>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 194, "\"", 229, 2);
            WriteAttributeValue("", 201, "/Categories/Details/", 201, 20, true);
#nullable restore
#line 10 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
WriteAttributeValue("", 221, item.ID, 221, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fcc9be92027439c15d6c91d8db912c40448c7775284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 263, "~/images/categories/", 263, 20, true);
#nullable restore
#line 11 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
AddHtmlAttributeValue("", 283, item.Image, 283, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </a>\r\n");
#nullable restore
#line 14 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
                 if (item.Percent != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"label-group\">\r\n                        <div class=\"product-label label-sale\">-");
#nullable restore
#line 17 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
                                                          Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                    </div>\r\n");
#nullable restore
#line 19 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </figure>

            <div class=""product-details"">
                <div class=""category-wrap"">
                    <div class=""category-list"">
                        <a href=""category.html"" class=""product-category""></a>
                    </div>
                </div>

                <h3 class=""product-title""> <a href=""product.html"">");
#nullable restore
#line 30 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </h3>

                <div class=""ratings-container"">
                    <div class=""product-ratings"">
                        <span class=""ratings"" style=""width:100%""></span>
                        <!-- End .ratings -->
                        <span class=""tooltiptext tooltip-top""></span>
                    </div>
                    <!-- End .product-ratings -->
                </div>
                <!-- End .product-container -->

                <div class=""price-box"">
                    <span class=""old-price"">$");
#nullable restore
#line 43 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
                                        Write(item.PastPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"product-price\">$");
#nullable restore
#line 44 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
                                            Write(item.PresentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                </div>
                <!-- End .price-box -->
                <div class=""product-action"">
                    <a href=""wishlist.html"" class=""btn-icon-wish"" title=""wishlist"">
                        <i class=""icon-heart""></i>
                    </a>
                    <a href=""#"" class=""btn-icon btn-add-cart product-type-simple"">
                        <i class=""icon-shopping-cart""></i><span>ADD TO CART</span>
                    </a>
                    <a href=""ajax/product-quick-view.html"" class=""btn-quickview"" title=""Quick View"">
                        <i class=""fas fa-external-link-alt""></i>
                    </a>
                </div>
            </div>
            <!-- End .product-details -->
        </div>
    </div>
");
#nullable restore
#line 63 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\BooksPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Books>> Html { get; private set; }
    }
}
#pragma warning restore 1591