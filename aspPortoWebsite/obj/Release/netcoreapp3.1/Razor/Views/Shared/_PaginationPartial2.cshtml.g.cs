#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df90d441ae818bbc3c1e48b711e250692f61967e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PaginationPartial2), @"mvc.1.0.view", @"/Views/Shared/_PaginationPartial2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df90d441ae818bbc3c1e48b711e250692f61967e", @"/Views/Shared/_PaginationPartial2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f974e427b9a28649861d05df1247dfc92a82e681", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PaginationPartial2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
 if (Model == null) { return; }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
  
    int pageCount = Model.PageCount;

    string url(int page = 1)
    {
        string pageOnUrl = page > 1 ? $"?page={page}" : "";
        return $"{Context.Request.Path}{pageOnUrl}";

    }

    string pointer_events(int page)
    {
        return Model.Page == page ? "style=pointer-events:none;" : "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
 if (pageCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n            <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 537, "\"", 560, 1);
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
WriteAttributeValue("", 544, url(Model.Prev), 544, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-page=\"");
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
                                                                   Write(Model.Prev);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"page-link\" ");
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
                                                                                                  Write(pointer_events(1));

#line default
#line hidden
#nullable disable
            WriteLiteral(">Əvvəl</a></li>\r\n");
#nullable restore
#line 26 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
             for (int i = Model.StartIndex; i <= Model.EndIndex; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 744, "\"", 796, 2);
            WriteAttributeValue("", 752, "page-item", 752, 9, true);
#nullable restore
#line 28 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
WriteAttributeValue("", 761, i == Model.Page ? " active" : "", 761, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 836, 1);
#nullable restore
#line 29 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
WriteAttributeValue("", 829, url(i), 829, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-page=\"");
#nullable restore
#line 29 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"page-link\">");
#nullable restore
#line 29 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 31 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 953, "\"", 976, 1);
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
WriteAttributeValue("", 960, url(Model.Next), 960, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-page=\"");
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
                                                                   Write(Model.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"page-link\" ");
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
                                                                                                  Write(pointer_events(1));

#line default
#line hidden
#nullable disable
            WriteLiteral(">Sonra</a></li>\r\n        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Views\Shared\_PaginationPartial2.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
