#pragma checksum "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f623c74a1ebe6bb9f31c9bca0952ce2f664e7c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\_ViewImports.cshtml"
using YY_Npoi_ExportAndImport;

#line default
#line hidden
#line 2 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\_ViewImports.cshtml"
using YY_Npoi_ExportAndImport.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f623c74a1ebe6bb9f31c9bca0952ce2f664e7c4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8dfb9e8767d20959017fa2b1452dac1408c993c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/wordPicture.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("530"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "NPOI导出Word文档示例";

#line default
#line hidden
            BeginContext(50, 194, true);
            WriteLiteral("<div class=\"layui-header header header-doc\" spring>\r\n    <div class=\"layui-main\">\r\n        <ul class=\"layui-nav\" id=\"nav\">\r\n            <li class=\"layui-nav-item layui-this\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 244, "\"", 278, 1);
#line 8 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
WriteAttributeValue("", 251, Url.Action("Index","Home"), 251, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(279, 129, true);
            WriteLiteral(" style=\"text-decoration:none;\">使用NPOI导出Word文档</a>\r\n            </li>\r\n            <li class=\"layui-nav-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 408, "\"", 462, 1);
#line 11 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
WriteAttributeValue("", 415, Url.Action("ExportExcelData","ExcelOperation"), 415, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(463, 130, true);
            WriteLiteral(" style=\"text-decoration:none;\">使用NPOI导出Excel文档</a>\r\n            </li>\r\n            <li class=\"layui-nav-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 593, "\"", 645, 1);
#line 14 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
WriteAttributeValue("", 600, Url.Action("Index","ExcelDataImportAndLook"), 600, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(646, 313, true);
            WriteLiteral(@" style=""text-decoration:none;"">将Excel文档数据数据批量导入到MySQL中</a>
            </li>
        </ul>
    </div>
</div>
<div style=""height: 20px;""></div>
<div class=""text-center"">
    <button type=""button"" class=""layui-btn layui-btn-fluid"" onclick=""wordExport()"" style=""width: 600px;"">导出并保存如下图所示的Word文档</button>
    ");
            EndContext();
            BeginContext(959, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f623c74a1ebe6bb9f31c9bca0952ce2f664e7c46508", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 281, true);
            WriteLiteral(@"
</div>
<script type=""text/javascript"">
    function wordExport() {
        var index = layer.msg('Work文档努力生成中...', { icon: 16, shade: 0.8, time: false });
        $.ajax({
            async: true,
            dataType: ""json"",
            type: ""post"",
            url: """);
            EndContext();
            BeginContext(1292, 31, false);
#line 31 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\YY_Npoi_ExportAndImport\Views\Home\Index.cshtml"
             Write(Url.Action("WordExport","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 299, true);
            WriteLiteral(@""",
            success: function (res) {
                layer.close(index);
                if (res.code == 1) {
                    window.location.href = res.data;
                } else {
                    alert(res.data);
                }
            }
        });
    }
</script>");
            EndContext();
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