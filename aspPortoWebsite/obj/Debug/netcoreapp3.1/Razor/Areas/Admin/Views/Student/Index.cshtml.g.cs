#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6196cfeb0b455b920eda26fa6e9d10bfc67f7c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6196cfeb0b455b920eda26fa6e9d10bfc67f7c85", @"/Areas/Admin/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5c1181384658460b14cca0f6e61bcf9e5b04d62", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<StudentAdress>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<div>
    <a href=""/Admin/Student/AddStudent"" style=""width:100%"" class=""btn btn-success"">Add new student</a>
</div>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Group</th>
            <th>Fullname</th>
            <th>City</th>
            <th>Adress</th>
            <th>Edit/Delete</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 23 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
                           Write(item.Student.Group.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 28 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
                           Write(item.Student.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 896, 2);
            WriteAttributeValue("", 860, "/Admin/Student/Edit/", 860, 20, true);
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
WriteAttributeValue("", 880, item.Student.Id, 880, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 971, "\"", 1016, 2);
            WriteAttributeValue("", 978, "/Admin/Student/Delete/", 978, 22, true);
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
WriteAttributeValue("", 1000, item.Student.Id, 1000, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediyinizden eminsiz?\')\" style=\"color:red\">\r\n                        <i class=\"fas fa-trash-alt\"></i>\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1248, 2);
            WriteAttributeValue("", 1210, "/Admin/Student/Details/", 1210, 23, true);
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"
WriteAttributeValue("", 1233, item.StudentId, 1233, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Student\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<StudentAdress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
