#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6d0ec730e70b8de5dd8a3dffc75bae312f93e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Service_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Service/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d0ec730e70b8de5dd8a3dffc75bae312f93e2b", @"/Areas/Admin/Views/Service/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd7c7d4bf5e06d8a3aa36d9ff471e6cc3bb1e75", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Service_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""overflow-x:scroll"">

    <div style=""margin-bottom:50px"">
        <a href=""/Admin/Service/Create"" class=""btn btn-outline-warning"" style=""width:1500px"">Add new slider</a>
    </div>

    <table class=""table table-bordered"" style=""width:1500px;"">
        <thead class=""bg-register-image"">
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Icon Link</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Header</th>
                <th>Edit/Delete</th>
            </tr>
        </thead>

        <tbody>

                <tr>
                    <th scope=""row"">");
#nullable restore
#line 31 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
                               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"row\">");
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
                               Write(Model.Iconlink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
                   Write(Html.Raw(Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
                   Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1138, "\"", 1174, 2);
            WriteAttributeValue("", 1145, "/Admin/Service/Edit/", 1145, 20, true);
#nullable restore
#line 39 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
WriteAttributeValue("", 1165, Model.Id, 1165, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1253, "\"", 1291, 2);
            WriteAttributeValue("", 1260, "/Admin/Service/Delete/", 1260, 22, true);
#nullable restore
#line 40 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
WriteAttributeValue("", 1282, Model.Id, 1282, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek isdediyinizden eminsinizmi?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                        <br />\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1470, "\"", 1509, 2);
            WriteAttributeValue("", 1477, "/Admin/Service/Details/", 1477, 23, true);
#nullable restore
#line 42 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Service\Details.cshtml"
WriteAttributeValue("", 1500, Model.Id, 1500, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                    </td>\r\n                </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
