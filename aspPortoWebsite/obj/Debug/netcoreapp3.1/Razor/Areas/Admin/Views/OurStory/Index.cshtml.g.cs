#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69df438e411c651e0983aa9e537a380ceac9401c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OurStory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/OurStory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69df438e411c651e0983aa9e537a380ceac9401c", @"/Areas/Admin/Views/OurStory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd7c7d4bf5e06d8a3aa36d9ff471e6cc3bb1e75", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_OurStory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<OurStory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""overflow-x:scroll"">

    <div style=""margin-bottom:50px"">
        <a href=""/Admin/Ourstory/Create"" class=""btn btn-outline-warning"" style=""width:1500px"">Add new slider</a>
    </div>

    <table class=""table table-bordered"" style=""width:1500px;"">
        <thead class=""bg-register-image"">
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Phorizm</th>
                <th>Edit/Delete</th>
            </tr>
        </thead>

        <tbody>

");
#nullable restore
#line 28 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
                   Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
                   Write(Html.Raw(item.Phorizm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1040, 2);
            WriteAttributeValue("", 1011, "/Admin/OurStory/Edit/", 1011, 21, true);
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
WriteAttributeValue("", 1032, item.Id, 1032, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1119, "\"", 1157, 2);
            WriteAttributeValue("", 1126, "/Admin/OurStory/Delete/", 1126, 23, true);
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
WriteAttributeValue("", 1149, item.Id, 1149, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek isdediyinizden eminsinizmi?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                        <br />\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1336, "\"", 1375, 2);
            WriteAttributeValue("", 1343, "/Admin/OurStory/Details/", 1343, 24, true);
#nullable restore
#line 38 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"
WriteAttributeValue("", 1367, item.Id, 1367, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\OurStory\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<OurStory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
