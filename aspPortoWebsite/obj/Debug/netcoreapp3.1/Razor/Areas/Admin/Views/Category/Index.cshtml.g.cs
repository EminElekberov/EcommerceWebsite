#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34569a96d69b179812ecfa10b79987ccb9a8ad12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
using aspPortoWebsite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using aspPortoWebsite.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34569a96d69b179812ecfa10b79987ccb9a8ad12", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5c1181384658460b14cca0f6e61bcf9e5b04d62", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Category>>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <a href=""/Admin/Category/Create"" class=""btn btn-success"" style=""width:100%"">Add new slider</a>
</div>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Image</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Count</th>
            <th scope=""col"">Description</th>
            <th>CRUD</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 28 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
                           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34569a96d69b179812ecfa10b79987ccb9a8ad126747", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 811, "~/images/demoes/demo3/categories/", 811, 33, true);
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
AddHtmlAttributeValue("", 844, item.Image, 844, 11, false);

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
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
               Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1042, "\"", 1078, 2);
            WriteAttributeValue("", 1049, "/Admin/Category/Edit/", 1049, 21, true);
#nullable restore
#line 39 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1070, item.ID, 1070, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1153, "\"", 1191, 2);
            WriteAttributeValue("", 1160, "/Admin/Category/Delete/", 1160, 23, true);
#nullable restore
#line 40 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1183, item.ID, 1183, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you sure\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    <br />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1361, 2);
            WriteAttributeValue("", 1329, "/Admin/Category/Details/", 1329, 24, true);
#nullable restore
#line 42 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1353, item.ID, 1353, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Category\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
