#pragma checksum "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0fbf628bd07851ef0dbc8c8c4a8a9e0a16ce0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Promotion_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Promotion/Index.cshtml")]
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
#line 1 "D:\DA\DongHo\DongHo\Areas\Admin\Views\_ViewImports.cshtml"
using DongHo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DA\DongHo\DongHo\Areas\Admin\Views\_ViewImports.cshtml"
using DongHo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0fbf628bd07851ef0dbc8c8c4a8a9e0a16ce0b", @"/Areas/Admin/Views/Promotion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad58d98061e9c481003e370733da328ed6c8165", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Promotion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Promotion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    var lstPromotion = (List<DongHo.Models.PromotionViewModel>)ViewBag.lstPromotion;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"success\"");
            BeginWriteAttribute("value", " value=\"", 158, "\"", 186, 1);
#nullable restore
#line 6 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 166, TempData["success"], 166, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"warning\"");
            BeginWriteAttribute("value", " value=\"", 225, "\"", 253, 1);
#nullable restore
#line 7 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 233, TempData["warning"], 233, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"error\"");
            BeginWriteAttribute("value", " value=\"", 290, "\"", 316, 1);
#nullable restore
#line 8 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 298, TempData["error"], 298, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<div class=""container-fluid"">
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách khuyến mãi</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc0fbf628bd07851ef0dbc8c8c4a8a9e0a16ce0b6169", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 26 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                 if (lstPromotion.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Hình ảnh</th>
                                <th>Tên</th>
                                <th>Link</th>
                                <th>Thứ tự</th>
                                <th>Trạng thái</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 41 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                 foreach (var item in lstPromotion)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 46 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 1968, "\"", 1984, 1);
#nullable restore
#line 47 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 1974, item.Logo, 1974, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:60px;\" /></td>\r\n                                        <td>");
#nullable restore
#line 48 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 49 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                       Write(item.DisplayOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                         if (item.Status == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><span class=\"btn-success\">Hiển thị</span></td>\r\n");
#nullable restore
#line 54 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><span class=\"btn-danger\">Ẩn</span></td>\r\n");
#nullable restore
#line 58 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2765, "\"", 2802, 2);
            WriteAttributeValue("", 2772, "/Admin/Promotion/Edit/", 2772, 22, true);
#nullable restore
#line 60 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 2794, item.Id, 2794, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary glyphicon glyphicon-pencilt\">Sửa</a>\r\n                                            <a class=\"btn btn-danger glyphicon glyphicon-trash\" onclick=\"return confirm(\'Bạn có muốn xóa không?\');\"");
            BeginWriteAttribute("href", " href=\"", 3012, "\"", 3061, 3);
#nullable restore
#line 61 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 3019, Url.Action("Delete","Promotion"), 3019, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3052, "/", 3052, 1, true);
#nullable restore
#line 61 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 3053, item.Id, 3053, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 64 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 68 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có khuyến mãi nào nào</span>\r\n");
#nullable restore
#line 72 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Promotion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
