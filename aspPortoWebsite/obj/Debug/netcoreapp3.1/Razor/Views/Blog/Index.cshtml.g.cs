#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed1f11bcf9633aa6c2f1008deb9be70ea7002d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed1f11bcf9633aa6c2f1008deb9be70ea7002d4", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f974e427b9a28649861d05df1247dfc92a82e681", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<MyBlogCollection>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""page-wrapper"" style=""margin-top:80px;"">
    <main class=""main"">
        <nav aria-label=""breadcrumb"" class=""breadcrumb-nav"">
            <div class=""container"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""demo4.html""><i class=""icon-home""></i></a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Blog</li>
                </ol>
            </div><!-- End .container -->
        </nav>

        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <div class=""blog-section row"">

");
#nullable restore
#line 18 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 col-lg-4\">\r\n                                <article class=\"post\">\r\n                                    <div class=\"post-media\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 985, "\"", 1014, 2);
            WriteAttributeValue("", 992, "/Blog/Details/", 992, 14, true);
#nullable restore
#line 23 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1006, item.Id, 1006, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ed1f11bcf9633aa6c2f1008deb9be70ea7002d46060", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1072, "~/images/blog/", 1072, 14, true);
#nullable restore
#line 24 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1086, item.Image, 1086, 11, false);

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
            WriteLiteral("\r\n                                        </a>\r\n                                        <div class=\"post-date\">\r\n                                            ");
#nullable restore
#line 27 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div><!-- End .post-media -->

                                    <div class=""post-body"">
                                        <h2 class=""post-title"">
                                            <a href=""single.html"">");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h2>\r\n                                        <div class=\"post-content\">\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 37 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </div><!-- End .post-content -->\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2027, "\"", 2056, 2);
            WriteAttributeValue("", 2034, "/Blog/Details/", 2034, 14, true);
#nullable restore
#line 40 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2048, item.Id, 2048, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-comment\">");
#nullable restore
#line 40 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                                                                                         Write(item.myBlogCollectionReviews.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments</a>\r\n                                    </div><!-- End .post-body -->\r\n                                </article><!-- End .post -->\r\n                            </div>\r\n");
#nullable restore
#line 44 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div><!-- End .col-lg-9 -->
                <div class=""sidebar-toggle custom-sidebar-toggle"">
                    <i class=""fas fa-sliders-h""></i>
                </div>

                <div class=""sidebar-overlay""></div>
                <aside class=""sidebar mobile-sidebar col-lg-3"">
                    <div class=""sidebar-wrapper"" data-sticky-sidebar-options='{""offsetTop"": 72}'>
                        <div class=""widget widget-post"">
                            <h4 class=""widget-title"">Recent Posts</h4>
");
#nullable restore
#line 56 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul class=\"simple-post-list\">\r\n                                    <li>\r\n                                        <div class=\"post-media\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3196, "\"", 3225, 2);
            WriteAttributeValue("", 3203, "/Blog/Details/", 3203, 14, true);
#nullable restore
#line 61 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3217, item.Id, 3217, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ed1f11bcf9633aa6c2f1008deb9be70ea7002d412136", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3287, "~/images/blog/", 3287, 14, true);
#nullable restore
#line 62 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 3301, item.Image, 3301, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </a>\r\n                                        </div><!-- End .post-media -->\r\n                                        <div class=\"post-info\">\r\n                                            <a>");
#nullable restore
#line 66 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <div class=\"post-meta\">");
#nullable restore
#line 67 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                                                              Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <!-- End .post-meta -->\r\n                                        </div><!-- End .post-info -->\r\n                                    </li>\r\n                                </ul>\r\n");
#nullable restore
#line 72 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Blog\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div><!-- End .widget -->

                        <div class=""widget"">
                            <h4 class=""widget-title"">Tags</h4>

                            <div class=""tagcloud"">
                                <a href=""#"">ARTICLES</a>
                                <a href=""#"">CHAT</a>
                            </div><!-- End .tagcloud -->
                        </div><!-- End .widget -->
                    </div><!-- End .sidebar-wrapper -->
                </aside><!-- End .col-lg-3 -->
            </div><!-- End .row -->
        </div><!-- End .container -->
    </main><!-- End .main -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<MyBlogCollection>> Html { get; private set; }
    }
}
#pragma warning restore 1591
