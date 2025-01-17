#pragma checksum "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a55c8f13f415f323251d68e59a43f1a85bd6bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_RevenueStatistic), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/RevenueStatistic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a55c8f13f415f323251d68e59a43f1a85bd6bc", @"/Areas/Admin/Views/Order/RevenueStatistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad58d98061e9c481003e370733da328ed6c8165", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_RevenueStatistic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RevenueStatistic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
  
    Layout = "_LayoutAdmin";
    var revenuesDate = (List<DongHo.Models.RevenueStatisticViewModel>)ViewBag.revenuesDate;
    var revenuesMonth = (List<DongHo.Models.RevenueStatisticMonthViewModel>)ViewBag.revenuesMonth;
    var revenuesYear = (List<DongHo.Models.RevenueStatisticYearViewModel>)ViewBag.revenuesYear;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Thống kê doanh thu</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item"">Doanh thu</li>
    </ol>
    <div class=""card mb-6"" style=""margin-bottom:30px;"">
        <div class=""card-body"">
            <div class=""row"" style=""margin-bottom:20px;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a55c8f13f415f323251d68e59a43f1a85bd6bc5424", async() => {
                WriteLiteral(@"
                    <div class=""form-group"" style=""margin-right:30px;"">
                        <label class=""control-label""> Từ ngày: </label>
                        <input name=""fromDate"" type=""datetime-local"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label""> Đến ngày: </label>
                        <input name=""toDate"" type=""datetime-local"" class=""form-control"" />
                    </div>
                    <div class=""col-6"" style="" margin-top: 28px;"">
                        <button type=""submit"" class=""btn btn-secondary"">Thống kê</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <h3>Doanh thu theo ngày</h3>\r\n            </div>\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 36 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                 if (revenuesDate.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Ngày</th>
                                <th>Doanh thu</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 47 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                 foreach (var item in revenuesDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 52 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(item.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(item.Revenues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 56 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 60 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có thống kê nào</span>\r\n");
#nullable restore
#line 64 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""card mb-6"" style=""margin-bottom:30px;"">
        <div class=""card-body"">
            <div>
                <h3>Doanh thu theo tháng</h3>
            </div>
            <div class=""table-responsive"">
");
#nullable restore
#line 76 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                 if (revenuesMonth.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Tháng</th>
                                <th>Doanh thu</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 87 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                 foreach (var item in revenuesMonth)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 92 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 93 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(item.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 94 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(item.Revenues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 96 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 100 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có thống kê nào</span>\r\n");
#nullable restore
#line 104 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card mb-6\">\r\n        <div class=\"card-body\">\r\n            <div>\r\n                <h3>Doanh thu theo năm</h3>\r\n            </div>\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 116 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                 if (revenuesYear.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Năm</th>
                                <th>Doanh thu</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 127 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                 foreach (var item in revenuesYear)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 132 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 133 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 134 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                       Write(item.Revenues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 136 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 140 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có thống kê nào</span>\r\n");
#nullable restore
#line 144 "D:\DA\DongHo\DongHo\Areas\Admin\Views\Order\RevenueStatistic.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
