#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed987f85e57492c079753c0509877e865b343dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filter_Index), @"mvc.1.0.view", @"/Views/Filter/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed987f85e57492c079753c0509877e865b343dd", @"/Views/Filter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f974e427b9a28649861d05df1247dfc92a82e681", @"/Views/_ViewImports.cshtml")]
    public class Views_Filter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SizeToBooks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("productr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row py-4\" style=\"margin-top:80px\">\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-6 col-sm-4 col-md-3 col-xl-2 appear-animate"" data-animation-name=""fadeIn""
             data-animation-delay=""300"" data-animation-duration=""1000"">
            <div class=""product-default inner-quickview inner-icon"">
                <figure>
                    <a");
            BeginWriteAttribute("href", " href=\"", 410, "\"", 451, 2);
            WriteAttributeValue("", 417, "/Categories/Details/", 417, 20, true);
#nullable restore
#line 11 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
WriteAttributeValue("", 437, item.Books.ID, 437, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ed987f85e57492c079753c0509877e865b343dd6505", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 489, "~/images/categories/", 489, 20, true);
#nullable restore
#line 12 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
AddHtmlAttributeValue("", 509, item.Books.Image, 509, 17, false);

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
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"label-group\">\r\n");
#nullable restore
#line 15 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                         if (item.Books.Percent != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"product-label label-hot\">HOT</div>\r\n                            <div class=\"product-label label-sale\">-");
#nullable restore
#line 18 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                                                              Write(item.Books.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n");
#nullable restore
#line 19 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""btn-icon-group"">
                        <a href=""#"" class=""btn-icon btn-add-cart product-type-simple"">
                            <i class=""icon-shopping-cart""></i>
                        </a>
                    </div>
                    <a href=""ajax/product-quick-view.html"" class=""btn-quickview"" title=""Quick View"">
                        Quick
                        View
                    </a>
                </figure>
                <div class=""product-details"">
                    
                    <h3 class=""product-title"">
                        <a href=""demo3-product.html"">");
#nullable restore
#line 34 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                                                Write(item.Books.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                    </h3>
                    <div class=""ratings-container"">
                        <div class=""product-ratings"">
                            <span class=""ratings"" style=""width:100%""></span><!-- End .ratings -->
                            <span class=""tooltiptext tooltip-top""></span>
                        </div><!-- End .product-ratings -->
                    </div><!-- End .product-container -->
                    <div class=""price-box"">
                        <span class=""old-price"">$");
#nullable restore
#line 43 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                                            Write(item.Books.PastPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"product-price\">$");
#nullable restore
#line 44 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                                                Write(item.Books.PresentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div><!-- End .price-box -->\r\n                </div><!-- End .product-details -->\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div style=\"margin-top:80px;\">\r\n");
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Image</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Present Price</th>
                <th scope=""col"">Past Price</th>
                <th scope=""col"">Percent</th>
                <th scope=""col"">Sku</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Additional Information</th>
                <th scope=""col"">Size</th>
            </tr>
        </thead>

        <tbody>

");
#nullable restore
#line 78 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ed987f85e57492c079753c0509877e865b343dd12642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3579, "~/images/categories/", 3579, 20, true);
#nullable restore
#line 83 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
AddHtmlAttributeValue("", 3599, item.Books.Image, 3599, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 85 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(item.Books.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(item.Books.PresentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 87 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(item.Books.PastPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 88 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(item.Books.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 89 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(item.Books.Sku);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 90 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(Html.Raw(item.Books.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(Html.Raw(item.Books.AdditionalInformation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"
                   Write(item.Size.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 94 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Filter\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SizeToBooks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
