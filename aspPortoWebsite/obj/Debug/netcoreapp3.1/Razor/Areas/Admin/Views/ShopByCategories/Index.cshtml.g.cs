#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31d1c6b27d36dfa20b5b4d936082953131da31dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ShopByCategories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ShopByCategories/Index.cshtml")]
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
#line 1 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using aspPortoWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using aspPortoWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using aspPortoWebsite.Models.ForBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using aspPortoWebsite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using aspPortoWebsite.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d1c6b27d36dfa20b5b4d936082953131da31dd", @"/Areas/Admin/Views/ShopByCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd7c7d4bf5e06d8a3aa36d9ff471e6cc3bb1e75", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ShopByCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ShopByCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""overflow-x: auto"">

    <div>
        <a href=""/Admin/ShopByCategories/Create"" class=""btn btn-outline-info"" style=""width:100%"">Add new student</a>
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Image</th>
                <th>Name</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 29 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31d1c6b27d36dfa20b5b4d936082953131da31dd7259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 858, "~/images/ShopByCategories/", 858, 26, true);
#nullable restore
#line 34 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
AddHtmlAttributeValue("", 884, item.Image, 884, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <th scope=\"row\">");
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
                               Write(item.ProductCategoryies.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1119, 2);
            WriteAttributeValue("", 1080, "/Admin/ShopByCategories/Delete/", 1080, 31, true);
#nullable restore
#line 38 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"
WriteAttributeValue("", 1111, item.Id, 1111, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediyinizden eminsiz?\')\" style=\"color:red\">\r\n                            <i class=\"fas fa-trash-alt\"></i>\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\ShopByCategories\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ShopByCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
