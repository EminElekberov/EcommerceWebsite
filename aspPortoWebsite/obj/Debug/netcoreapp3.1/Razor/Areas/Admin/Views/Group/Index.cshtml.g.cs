#pragma checksum "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Group\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c2bcb4eb96673576a8ff1c4fc5f5e5a5f9aeae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Group_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Group/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2bcb4eb96673576a8ff1c4fc5f5e5a5f9aeae0", @"/Areas/Admin/Views/Group/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fb6a2dfe3e452210bddf2a07fecdf71cf58e45c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Group>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editGroupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3\" crossorigin=\"anonymous\">\r\n");
            }
            );
            WriteLiteral(@"<h1>Index</h1>
<button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#createModal"">
    Create
</button>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Ad</th>
            <th scope=""col"">Emeliyyat</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Group\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
#nullable restore
#line 23 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Group\Index.cshtml"
                           Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-primary btnEdit\" data-id=\"");
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Group\Index.cshtml"
                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-bs-toggle=\"modal\" data-bs-target=\"#editModal\">\r\n                        Edit\r\n                    </button>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 948, "\"", 983, 2);
            WriteAttributeValue("", 955, "/Admin/Group/Delete/", 955, 20, true);
#nullable restore
#line 28 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Group\Index.cshtml"
WriteAttributeValue("", 975, item.Id, 975, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"delete-btn\" style=\"color:red\">\r\n                        <i class=\"fas fa-trash-alt\"></i>\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\aspPortoWebsite\aspPortoWebsite\Areas\Admin\Views\Group\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>
</table>

<!-- Modal -->
<div class=""modal fade"" id=""createModal"" tabindex=""-1"" aria-labelledby=""createModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModalLabel""> Create Form</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c2bcb4eb96673576a8ff1c4fc5f5e5a5f9aeae07634", async() => {
                WriteLiteral("\r\n                    <div class=\"mb-3\">\r\n                        <label class=\"form-label\">Name</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"groupName\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button id=""btnCreate"" type=""button"" class=""btn btn-primary"">SaveChanges</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""editModal"" tabindex=""-1"" aria-labelledby=""editModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editModalLabel"">Edit Forrm</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c2bcb4eb96673576a8ff1c4fc5f5e5a5f9aeae010169", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""editId"" />
                    <div class=""mb-3"">
                        <label class=""form-label"">Name</label>
                        <input type=""text"" class=""form-control"" id=""editGroupName"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""submit"" form=""editGroupForm"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" referrerpolicy=""no-referrer""></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>

    <script>
        $(document).ready(() => {
            $(document).on('click', '#btnCreate', (e) => { //e klik olunan yerin melumatlarini ozunde saxlayir
                $.ajax({
                    url: '/Admin/Group/Create',
                    type: 'POST',
                    data: { name: $('#groupName').val() },
                    success: (response) => {
                        if (response.hasOwnProperty('status') && response.status === 200) {
                            location.href = '/Admin/Group/Index';
                        } else if (response.status === 400) {
               ");
                WriteLiteral(@"             alert(""Tapilmadi"");
                        }
                    }
                })
            });

            $(document).on('click', '.btnEdit', (e) => {
                const id = $(e.currentTarget).data('id');
                $.ajax({
                    url: `/Admin/Group/edit/${id}`,
                    type: 'GET',
                    success: (response) => {
                        if (response.hasOwnProperty('status') && response.status === 404) {
                            alert('tapilmadi')
                        } else {
                            console.log(response);
                            $('#editGroupName').val(response.fullname);
                            $('#editId').val(response.id);
                        }
                    }

                });


            });

            $('#editGroupForm').submit((e) => {
                e.preventDefault();
                $.ajax({
                    url: `/Admin/Group/edit`,
          ");
                WriteLiteral(@"          headers: {
                        'RequestVerificationToken': $('input[name=""__RequestVerificationToken""]').val()  //validateantiforgeredtokene gondermek ucun isdifade olnur
                    },
                    type: 'POST',
                    data: { id: $('#editId').val(), name: $('#editGroupName').val() },
                    success: (response) => {
                        if (response.hasOwnProperty('status')) {
                            if (response.status == 200) {
                                location.href = '/Admin/Group/index';
                            } else if (response.status == 400) {
                                alert('olmadi');
                            }
                        }
                    }

                })
            });

            $(document).on('click', '.delete-btn', function (e) {
                e.preventDefault();
                let url = $(this).attr(""href"");
                let element = this.parentElement.parentEl");
                WriteLiteral(@"ement;
                var __RequestVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
                Swal.fire({
                    title: 'Silmək istədiyinizdən əminsinizmi?',
                    text: ""Sildikdən sonra geri qaytarmaq mümkün olmayacaq!"",
                    type: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Sil',
                    cancelButtonText: 'Geri'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: url,
                            type: ""get"",
                            beforeSend: function (request) {
                                request.setRequestHeader('RequestVerificationToken', $(""input[name='__RequestVerificationToken']"").val());
                            },
                            dataTy");
                WriteLiteral(@"pe: ""json"",
                            success: function (response) {
                                if (response.status == 200) {
                                    //console.log(""dada"")
                                    Swal.fire(
                                        'Silindi!',
                                        '',
                                        'success'
                                    )
                                    //toastr.success(response.message)
                                    /*setTimeout(function () {
                                        window.location.reload();
                                    }, 200)*/
                                    element.outerHTML = '';
                                }
                                else if (response.status == 400) {
                                    //toastr.error(response.message)
                                }
                            }
                        });
              ");
                WriteLiteral("      }\r\n                })\r\n            });\r\n        })\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
